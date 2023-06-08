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
    public partial class AboutForm : Form
    {
        public delegate Tuple<string, Font, Color> TextPropertiesDelegate();

        public AboutForm()
        {
            InitializeComponent();
            AboutBox.ReadOnly = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Disable resize

            Random rnd = new Random();
            int num = rnd.Next(1, 4); // generates a number between 1 and 3

            if (num == 1)
                AboutBox.MyText(S1);
            else if (num == 2)
                AboutBox.MyText(S2);
            else
                AboutBox.MyText(S3);
        }

        public Tuple<string, Font, Color> S1()
        {
            return Tuple.Create("My Home Work", new Font("Arial", 30, FontStyle.Regular), Color.Red);
        }

        public Tuple<string, Font, Color> S2()
        {
            // replace with your own settings
            return Tuple.Create("HW2!!!", new Font("Times New Roman", 42, FontStyle.Regular), Color.Blue);
        }

        public Tuple<string, Font, Color> S3()
        {
            // replace with your own settings
            return Tuple.Create("HW2!", new Font("Courier New", 22, FontStyle.Regular), Color.Green);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AboutBox_Click(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }
    }
}

