using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMS_PRO_MAX.Logs;

namespace AMS_PRO_MAX
{
    
    public partial class Form1 : Form
    { 
        DB_AMS_PROEntities5 db = new DB_AMS_PROEntities5();
        dialog dialo = new dialog();
        private Cls_alert alert;
        FRM_HOME fRM_HOME ;
        details details;
        Logs.Logs logs;
        User user1 = new User();
        string fullname;
        public Form1()
        {
            InitializeComponent();
            
        }
        public Form1(User user)
        {
            InitializeComponent();
            user1 = user;
        }
        public void getfullname(User user)
        {
             
            fullname= user.Fullname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            

            if (pn_home.Visible == false)
            {
                pn_home.Visible = true;
                frm_txt_user.Text = Convert.ToString(db.Users.Count());
                txt_cot_alert.Text = Convert.ToString(db.Alerts.Count());
                txt_cont_item.Text = Convert.ToString(db.Items.Count());
            }
            else
            {
                

                pn.Controls.Clear();
                
                pn.Controls.Add(pn_home);
      
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (pn_lift.Width == 250)
            {
                pn_lift.Width = 50;
                pn_had.Visible = false;

            }
            else
            {
                pn_lift.Width = 250;
                pn_had.Visible = true;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_cot_alert.Text = Convert.ToString(db.Alerts.Count());
            fRM_HOME = new FRM_HOME(fullname);
            pn.Controls.Clear();
            pn.Controls.Add(fRM_HOME.pn_cat);
            db = new DB_AMS_PROEntities5();
            fRM_HOME.dataGridView1.DataSource = db.Items.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FRM_ADD fadd = new FRM_ADD();
            fadd.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
           /* Login log = new Login();
            this.Enabled = false;
            log.Show();
            this.Hide();*/
            
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
/*            dialo = new dialog();
            var res = MessageBox.Show("هل انت متاكد من هذه العملية", "تسجيل الخروج", MessageBoxButtons.YesNo);
             if(res==DialogResult.Yes)
            {
                
                dialo.label6.Text = "تم تسجيل الخروج";
                dialo.Show();
                btn_login.Enabled = true;
                btn_login.Visible = true;
                btn_cancel.Visible = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                btn_alert.Enabled = false;
                txt_cot_alert.Visible = false;
                pn.Controls.Clear();
                txt_username.Text = "اسم مستخدم";
            }*/

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FRM_ADDuser fru = new FRM_ADDuser();
            fru.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            alert = new Cls_alert();
            alert.alert();
            FRM_Alert fal = new FRM_Alert();
            fal.Show();
            txt_cot_alert.Text = Convert.ToString(db.Alerts.Count());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            details = new details();
            frm_txt_user.Text =Convert.ToString( db.Users.Count());
            txt_cont_item.Text= Convert.ToString(db.Items.Count());
            txt_cot_alert.Text = Convert.ToString(db.Alerts.Count());
            var cont = Convert.ToInt32(txt_cot_alert.Text);
            if (cont != 0)
            {
                details.txt_det.Text = "لديك تنبيهات";
                details.timer1.Interval = 10000;
                details.Show();
            }

            /*FRM_Alert fal = new FRM_Alert();
            fRM_HOME = new FRM_HOME();
            db = new DB_AMS_PROEntities5();
            fal.dataGridView1.DataSource = db.Alerts.ToList();
            fRM_HOME.dataGridView1.DataSource = db.Items.ToList();*/
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
           var add = db.Users.Where(x => x.state == true ).FirstOrDefault();
            if(add!=null)
            {
                add.state = false;
            }
            db.SaveChanges();


            Application.Exit();

        }

        private void frm_txt_user_Click(object sender, EventArgs e)
        {

        }
        public string usern()
        {
            return txt_username.Text;
        }

        private void txt_cot_alert_Click(object sender, EventArgs e)
        {

        }

        private void pn_lift_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dialo = new dialog();
            dialo.label6.Text = "ستتوفر قريباً";
            dialo.timer1.Interval = 500;
            dialo.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dialo = new dialog();
            dialo.label6.Text = "ستتوفر قريباً";
            dialo.timer1.Interval = 500;
            dialo.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dialo = new dialog();
            dialo.label6.Text = "ستتوفر قريباً";
            dialo.timer1.Interval = 500;
            dialo.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {  
            dialo = new dialog();
            dialo.label6.Text = "ستتوفر قريباً";
            dialo.timer1.Interval = 500;
            dialo.Show();
        }

        private void button9(object sender, EventArgs e)
        {
            dialo = new dialog();
            dialo.label6.Text = "ستتوفر قريباً";
            dialo.timer1.Interval = 500;
            dialo.Show();
        }

        private void txt_username_Click(object sender, EventArgs e)
        {

        }
        public string set_name()
        {
            return txt_username.Text;
        }
        public string set_n()
        {
            return txt_username.Text;
        }

        private void txt_role_Click(object sender, EventArgs e)
        {

        }

        private void btn_logs_Click(object sender, EventArgs e)
        {
            logs = new Logs.Logs();
            logs.Show();
            
        }
    }
}
