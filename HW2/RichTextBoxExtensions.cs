using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2
{
    public static class RichTextBoxExtensions
    {
        public static void MyText(this RichTextBox rtb, HW2.AboutForm.TextPropertiesDelegate del)
        {
            var result = del();
            rtb.Text = result.Item1;
            rtb.Font = result.Item2;
            rtb.ForeColor = result.Item3;
        }
    }
}
