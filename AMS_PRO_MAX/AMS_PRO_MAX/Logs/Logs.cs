using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS_PRO_MAX.Logs
{
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
        }

        private void Logs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_AMS_PRODataSet4.Logs' table. You can move, or remove it, as needed.
            this.logsTableAdapter.Fill(this.dB_AMS_PRODataSet4.Logs);
            // TODO: This line of code loads data into the 'dB_AMS_PRODataSet4.Logs' table. You can move, or remove it, as needed.
            
        }
    }
}
