using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS_PRO_MAX
{
    public static class DialogHelper
    {
        public static void ShowDialog(Form parentForm, string message)
        {
            dialog dialog = new dialog();
            dialog.Width = parentForm.Width;
            dialog.label6.Text = message;
            dialog.timer1.Interval = 1000;
            dialog.Show();
        }
        public static void ShowDetails( string message)
        {
            details details = new details();
            details.txt_det.Text = message;
            details.Show();
        }
    }
}
