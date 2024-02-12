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
       // Cls_Login Logi;
        public DB_AMS_PROEntities5 db = new DB_AMS_PROEntities5();
        public Form1 main ;
        public int id;
        public User add;
        public bool state;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Checklogin();
        }

        public bool Checklogin()
        {
            // check fields
            try
            {
                //التحقق اذا المستخدم لم يدخل كلمة المرور او اسم
                if (!ValidationHelper.CheckIsEmpty(txt_username.Text, txt_pass.Text))
                {
                    main = new Form1();
                    var username = txt_username.Text;
                    var password = txt_pass.Text;

                    //مقارنة بيانات المستخدم في قاعدة البيانات اذا صحيحة يفتح الوجهة الرئسية
                    DatabaseHelper.CheckUser(username, password, this, main);

                    
                    return true;
                }
                // هده الكلاس يظهر رسالة في الواجهة
                DialogHelper.ShowDialog(this, "الحقل مطلوب");
                return false;
            }
            catch
            {
                MessageBox.Show("no server");
                return false;
            }
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e) {   }

        private void Login_Enter(object sender, EventArgs e)   {  }

        private void Login_Load(object sender, EventArgs e)  {  }

        private void Login_Leave(object sender, EventArgs e)  { }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
