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


        public DBForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(DBForm_Load);
        }
        private void DBForm_Load(object sender, EventArgs e)
        {
            using (var db = new GamesDBDataContext())
            {
                // Get the total number of records
                int totalRecord = db.Records.Count();

                // Calculate the total number of pages
                totalPage = (totalRecord / pageSize) + ((totalRecord % pageSize) > 0 ? 1 : 0);

                // Load the data for the current page
                dataGridView1.DataSource = db.Records
                    .OrderBy(t => t.Id) // replace "Id" with your primary key column
                    .Skip((currentPage - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {

        }

        private void PageTextBox_Click(object sender, EventArgs e)
        {

        }

        private void MaxPageLabel_Click(object sender, EventArgs e)
        {

        }

        private void NextButton2_Click(object sender, EventArgs e)
        {

        }

        private void Q1Button_Click(object sender, EventArgs e)
        {

        }

        private void Q2Button_Click(object sender, EventArgs e)
        {

        }

        private void AllButton_Click(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {

        }
    }
}
