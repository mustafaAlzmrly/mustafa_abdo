using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS_PRO_MAX
{
    public partial class Login : Form
    {
        DB_AMS_PROEntities5 db = new DB_AMS_PROEntities5();
        Form1 main = new Form1();
        User use = new User();
        
        public int id;
        bool state;
        User add;
        
        public Login()
        {
            InitializeComponent();
            
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }
        private void show_btn()
        {
            Form1 frm = new Form1();
            frm.button1.Enabled = true;

        }
        private bool Save()
        {
            dialog dialog = new dialog();
            // check fields

            if (edt_username.Text == "" || edt_password.Text == "")
            {
                dialog.Width = this.Width;
                dialog.label6.Text = "الحقل مطلوب";
                dialog.timer1.Interval = 1000;
                dialog.Show();
            }
        
            else
            {
                 
                if (id == 0)
                {
                    
                    // Check Duplicate Data



                    
                    AddData();
                    state = true;


                }
               

            }
            return state;
       }
        private void AddData()
        {

            try
            {
                details details = new details();
                dialog dialog = new dialog();
                db = new DB_AMS_PROEntities5();
                add = new User();
                var username = edt_username.Text;
                var password = edt_password.Text;
                add = db.Users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
                if (add != null)
                {
                    // Login

                    main = new Form1();
                    main.txt_username.Text = add.Fullname;
                    if(add.RoleID==2)
                    {
                        main.btn_users.Enabled = false;
                        main.button8.Enabled = false;
                        main.txt_role.Text = "موظف";

                    }
                    else if(add.RoleID == 1)
                    {
                        main.txt_role.Text = "نائب رائيس";
                    }
                    else if(add.RoleID == 99)
                    {
                        main.txt_role.Text = "الرائبس التنفيدي";
                    }
                    add.state = true;
                   // add.UserState = 1;
                    db.Entry(add).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    main.Show();

                    this.Hide();


                }
                else
                {
                    dialog.Width = this.Width;
                    dialog.label6.Text = "خطأ في معلومات تسجيل الدخول";
                    dialog.Show();
                }



            }
            catch
            {

                MessageBox.Show("no server");
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();


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
