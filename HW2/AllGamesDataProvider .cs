using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2
{
    public class AllGamesDataProvider : IPagedDataProvider
    {
        private int pageSize;
        private int totalPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ToolStripLabel maxPageLabel;
        private ToolStripTextBox currentPageTextBox; // Add a TextBox reference

        public AllGamesDataProvider(int pageSize, System.Windows.Forms.DataGridView dataGrid, ToolStripLabel maxPageLabel, ToolStripTextBox currentPageTextBox)
        {
            this.pageSize = pageSize;
            dataGridView1 = dataGrid;
            this.maxPageLabel = maxPageLabel;
            this.currentPageTextBox = currentPageTextBox; // Initialize the TextBox
            CalculateTotalPages();
        }

        public void LoadPage(int pageNumber)
        {
            using (var db = new GamesDBDataContext())
            {
                // Group the games by player and select the longest game from each group
                var games = db.Records
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

                // Display the longest games in dataGridView1
                dataGridView1.DataSource = games;
                currentPageTextBox.Text = pageNumber.ToString(); // Update the text box
            }
        }

        public int GetTotalPages()
        {
            return totalPage;
        }

        private void CalculateTotalPages()
        {
            using (var db = new GamesDBDataContext())
            {
                var totalRecords = db.Records.Count();
                totalPage = (int)Math.Ceiling(totalRecords / (double)pageSize);
                maxPageLabel.Text = totalPage.ToString(); // update the MaxPageLabel
            }
        }
    }
}
