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
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Disable resize
            // Wire up the Load event handler
            this.Load += ExitForm_Load;
        }
        private void ExitForm_Load(object sender, EventArgs e)
        {
            // Set the desired button as the active control
            NoButton.Focus();
        }
        private void YesButton_Click(object sender, EventArgs e)
        {
            // Close the program
            Application.Exit();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }
    }
}
