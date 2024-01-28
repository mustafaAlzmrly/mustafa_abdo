using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace AMS_PRO_MAX.UserP 
{
    public class Cls_Login
    {
        public DB_AMS_PROEntities5 db = new DB_AMS_PROEntities5();
        Form1 main ;
        public int id;
        public bool state;
        public User add;

        public bool Save(Login login)
        {
            main = new Form1();
            dialog dialog = new dialog();
            // check fields

            if (login.edt_username.Text == "" || login.edt_password.Text == "")
            {
                dialog.Width = login.Width;
                dialog.label6.Text = "الحقل مطلوب";
                dialog.timer1.Interval = 1000;
                dialog.Show();
            }

            else
            {

                if (id == 0)
                {

                    // Check Duplicate Data




                    AddData(login);
                    state = true;


                }


            }
            return state;
        }
        private void AddData(Login login)
        {
            main = new Form1();
            try
            {
                details details = new details();
                dialog dialog = new dialog();
                db = new DB_AMS_PROEntities5();
                add = new User();
                var username = login.edt_username.Text;
                var password = login.edt_password.Text;
                add = db.Users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
                if (add != null)
                {
                    // Login

                    main = new Form1();
                    main.txt_username.Text = add.Fullname;
                    if (add.RoleID == 2)
                    {
                        main.btn_users.Enabled = false;
                        main.button8.Enabled = false;
                        main.txt_role.Text = "موظف";

                    }
                    else if (add.RoleID == 1)
                    {
                        main.txt_role.Text = "نائب رائيس";
                    }
                    else if (add.RoleID == 99)
                    {
                        main.txt_role.Text = "الرائبس التنفيدي";
                    }
                    add.state = true;
                    // add.UserState = 1;
                    db.Entry(add).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    main.Show();

                    login.Hide();


                }
                else
                {
                    dialog.Width = login.Width;
                    dialog.label6.Text = "خطأ في معلومات تسجيل الدخول";
                    dialog.Show();
                }



            }
            catch
            {

                MessageBox.Show("no server");
            }
        }
    }
}
