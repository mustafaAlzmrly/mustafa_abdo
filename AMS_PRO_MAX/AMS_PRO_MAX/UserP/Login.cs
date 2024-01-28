using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMS_PRO_MAX.UserP;

namespace AMS_PRO_MAX
{
    
    public partial class Login : Form
    {
        Cls_Login Logi;
        public DB_AMS_PROEntities5 db = new DB_AMS_PROEntities5();
        public Form1 main = new Form1();
        
        public Login()
        {
            InitializeComponent();
            
        }



        private void show_btn()
        {
            Form1 frm = new Form1();
            frm.button1.Enabled = true;

        }
       
       

        private void btn_login_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logi = new Cls_Login();
            Logi.Save(this);
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //main.Show();
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
