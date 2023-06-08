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
        public DBForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(DBForm_Load);
        }
        private void DBForm_Load(object sender, EventArgs e)
        {
            using (var db = new GamesDBDataContext())
            {
                dataGridView1.DataSource = db.Records.ToList();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
