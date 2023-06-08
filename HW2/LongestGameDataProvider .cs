using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2
{
    public class LongestGameDataProvider : IPagedDataProvider
    {
        private int pageSize;
        private int totalPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ToolStripLabel maxPageLabel;
        private ToolStripTextBox currentPageTextBox; // Add a TextBox reference


        public LongestGameDataProvider(int pageSize, System.Windows.Forms.DataGridView dataGrid, ToolStripLabel maxPageLabel, ToolStripTextBox currentPageTextBox)
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
                var longestGamesQuery = db.Records
                 .GroupBy(t => t.Name)
                 .Select(g => g.OrderByDescending(t => t.Length).First());

                var longestGames = longestGamesQuery
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                // Display the players in dataGridView1
                dataGridView1.DataSource = longestGames;
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
                var longestGamesQuery = db.Records
                    .GroupBy(t => t.Name)
                    .Select(g => g.OrderByDescending(t => t.Length).First());

                var totalRecords = longestGamesQuery.Count();
                totalPage = (int)Math.Ceiling(totalRecords / (double)pageSize);
                maxPageLabel.Text = totalPage.ToString(); // update the MaxPageLabel
            }
        }
    }
}
