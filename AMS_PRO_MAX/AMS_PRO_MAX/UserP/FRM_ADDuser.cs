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
    public partial class FRM_ADDuser : Form
    {
        public string name;
        DB_AMS_PROEntities6 db = new DB_AMS_PROEntities6();
        public int id;
        public FRM_ADDuser()
        {
            InitializeComponent();

        }
        private void btn_saveAndClose_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            this.Close();
        }

        private void btn_saveUser_Click(object sender, EventArgs e)
        {
            Save();
        }
        private bool Save()
        {
            // check fields
            try
            {
                if (!ValidationHelper.ValidateAllFields(edt_name.Text, edt_username.Text, edt_password.Text, comboBox1.Text))
                {

                    if (DatabaseHelper.CheckDuplicateData(edt_username.Text) == true)
                    {
                        AddData();

                        DialogHelper.ShowDialog(this, "تمت اضافة مستخدم جديد من قبل " + name_user());
                        return true;

                    }

                    DialogHelper.ShowDialog(this, "اسم المستخدم مكرر"); return false;

                }

                DialogHelper.ShowDialog(this, "اكمل الحقل لطفا");

                return false;
            }
            catch
            {
                MessageBox.Show("يوجد مشكلة في الاضافة");
                return false;
            }
           
        }
        private void AddData()
        {
            try
            {
                Users newUser = new Users();
                newUser.Username = edt_name.Text;
                newUser.Password = edt_username.Text;
                newUser.Fullname = edt_password.Text;
                newUser.State = false;
                newUser.RoleID = RoleHelper.GetRoleId(comboBox1.Text);

                DatabaseHelper.SaveUser(newUser);

            }
            catch
            {
                MessageBox.Show("no server");

            }
        }
        public string name_user()
        {
            var add = db.Users.Where(x => x.state == true).FirstOrDefault();
            return add.Fullname;
        }
    }
}
