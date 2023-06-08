using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2
{
    public partial class DBForm : Form
    {
        private int currentPage = 1;
        private int pageSize = 5;
        private int totalPage = 0;
        private IPagedDataProvider currentDataProvider;


        public DBForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(AllButton_Click);
            PageTextBox.Leave += new EventHandler(txtPageNumber_Leave);

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                currentDataProvider.LoadPage(currentPage);
            }
        }

        private void NextButton2_Click(object sender, EventArgs e)
        {
            if (currentPage < currentDataProvider.GetTotalPages())
            {
                currentPage++;
                currentDataProvider.LoadPage(currentPage);
            }
        }

        private void PageTextBox_Click(object sender, EventArgs e)
        {

        }

        private void MaxPageLabel_Click(object sender, EventArgs e)
        {

        }

        private void Q1Button_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            totalPage = 1;
            MaxPageLabel.Text = totalPage.ToString();
            PageTextBox.Text = currentPage.ToString();
            using (var db = new GamesDBDataContext())
            {
                // Get the maximum length
                var maxLength = db.Records.Max(t => t.Length); 

                // Get the player(s) with the maximum length
                var players = db.Records.Where(t => t.Length == maxLength).ToList();

                // Display the players in dataGridView1
                dataGridView1.DataSource = players;
            }
        }

        private void Q2Button_Click(object sender, EventArgs e)
        {
            currentDataProvider = new LongestGameDataProvider(pageSize, dataGridView1, MaxPageLabel, PageTextBox);
            currentDataProvider.LoadPage(1);
        }

        private void AllButton_Click(object sender, EventArgs e)
        {
            currentDataProvider = new AllGamesDataProvider(pageSize, dataGridView1, MaxPageLabel, PageTextBox);
            currentDataProvider.LoadPage(1);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }
        private void txtPageNumber_Leave(object sender, EventArgs e)
        {
            // Parse the number from the TextBox
            int newPage;
            if (int.TryParse(PageTextBox.Text, out newPage))
            {
                // Check if the new page number is valid
                if (newPage >= 1 && newPage <= totalPage)
                {
                    // Set the new page number and refresh the data
                    currentPage = newPage;
                    currentDataProvider.LoadPage(currentPage);
                }
                else
                {
                    MessageBox.Show("Invalid page number.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
