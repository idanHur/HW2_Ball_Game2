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
    public partial class NameForm : Form
    {
        public string PlayerName { get; private set; }

        public NameForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Disable resize
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string playerName = playerNameTextBox.Text.Trim(); // Retrieve the text from the TextBox and remove leading/trailing whitespace
            if (!string.IsNullOrEmpty(playerName))
            {
                // Player name is not empty
                PlayerName = playerName; // Assign the player name to the public property
                DialogResult = DialogResult.OK; // Set the DialogResult of the form to DialogResult.OK
                Close(); // Close the form
            }
            else
            {
                // Player name is empty or only contains whitespace
                ErrorNameLabel.Text = "Invalid input! Please enter a valid player name.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameForm_Load(object sender, EventArgs e)
        {

        }

        private void EnterNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
