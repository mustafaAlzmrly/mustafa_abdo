﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMS_PRO_MAX.UserP;
using System.Windows.Forms;

namespace AMS_PRO_MAX
{
    public static class DatabaseHelper
    {
        public static string mess;
        

        //////////////user/////////////
        public static void SaveUser(Users newUser)
        {
            try
            {
                using (DB_AMS_PROEntities5 db = new DB_AMS_PROEntities5())
                {
                    User add = new User()
                    {
                        Fullname = newUser.Fullname,
                        Username = newUser.Username,
                        Password = newUser.Password,
                        RoleID = newUser.RoleID,
                        state = newUser.State,
                    };

                    db.Entry(add).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                }

            }
            catch
            {
                MessageBox.Show("no server");
            }
        }
        public static void CheckUser(string username, string pass, Form login, Form1 main)
        {
            try
            {
                // استخدام قاعدة البيانات
                using (var db = new DB_AMS_PROEntities5())
                {

                    // البحث عن المستخدم
                    var user = db.Users.Where(x => x.Username == username && x.Password == pass).FirstOrDefault();
                    if (user != null)
                    {
                        //طباعة وظيفة المسخدم الحالي في الواجهة الرائسية والاسم
                        main.txt_role.Text = user.RoleName;
                        main.txt_username.Text = user.Fullname;

                        db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        main.getUser(user);
                        //اظهار الواجهة الرئسية
                        main.Show();

                        login.Hide();
                    }
                    else
                    {
                        // اذخل المعلومات غير صحيحة
                        DialogHelper.ShowDialog(login, "خطأ في معلومات تسجيل الدخول");
                    }
                }
            }
            catch
            {

            }
        }
        public static bool CheckDuplicateData(string username)
        {
            try
            {
                using (DB_AMS_PROEntities5 db = new DB_AMS_PROEntities5())
                {
                    User add = new User();
                    add = db.Users.Where(x => x.Username == username).FirstOrDefault();
                    if (add == null)
                    {
                        return true;
                    }
                    else
                    {
                       return false;
                    }
                }

                  
            }
            catch
            {
                return false;

            }
 

        }

        /////////////Alert fun/////////
        public static void DeleteAlerts(List<int> alertIds)
        {
            using (var db = new DB_AMS_PROEntities5())
            {
                foreach (var id in alertIds)
                {
                    var alert = db.Alerts.FirstOrDefault(x => x.AlertID == id);
                    if (alert != null)
                    {
                        db.Alerts.Remove(alert); // حذف العنصر من قاعدة البيانات
                    }
                }
                db.SaveChanges();
            }
        }

        /////////////Item Fun//////////
        public static List<Item> SearchItems(string searchTerm)
        {
            using (var db = new DB_AMS_PROEntities5())
            {
                var searchResults = db.Items.Where(item =>
                    item.Name.ToString().Contains(searchTerm) ||
                    item.ItemID.ToString().Contains(searchTerm) ||
                    item.ExpiryDate.ToString().Contains(searchTerm) ||
                    item.QuantityAvailable.ToString().Contains(searchTerm) ||
                    item.Description.ToString().Contains(searchTerm) ||
                    item.Price.ToString().Contains(searchTerm)
                ).ToList();
                return searchResults;
            }
        }
        public static void AddNewItem(FRM_ADD frm)
        {
            try
            {
                Item tb_item = new Item();
                if (string.IsNullOrEmpty(frm.txt_name.Text) || string.IsNullOrEmpty(frm.txt_price.Text) ||
                           string.IsNullOrEmpty(frm.txt_qun.Text) || string.IsNullOrEmpty(frm.txt_dat.Text))
                {
                    DialogHelper.ShowDialog(frm, "يرجى ملء جميع الحقول");

                }
                else
                {
                    using (var db = new DB_AMS_PROEntities5())
                    {
                        var existingItem = db.Items.FirstOrDefault(item => item.Name == frm.txt_name.Text);
                        if (existingItem != null)
                        {
                            DialogHelper.ShowDialog(frm, "اسم الصنف مكرر");

                        }
                        else
                        {
                            tb_item.Name = frm.txt_name.Text;
                            tb_item.QuantityAvailable = Convert.ToInt32(frm.txt_qun.Text);
                            tb_item.Price = Convert.ToInt32(frm.txt_price.Text);
                            tb_item.Description = frm.txt_des.Text;
                            tb_item.ExpiryDate = frm.txt_dat.Value;
                            db.Items.Add(tb_item);
                            db.SaveChanges();
                            DialogHelper.ShowDetails("تم اضافة صنف");
                            // تحديث عدد الاشعارات
                            Form1 form = new Form1();
                            form.txt_cot_alert.Text = Convert.ToString(db.Alerts.Count());
                        }
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("no server");
            }
           
        }
        public static void EditShow(int itemId,Form frm,string fullname)
        {
            using (var db = new DB_AMS_PROEntities5())
            {
                var item = db.Items.Find(itemId);
                if (item != null)
                {
                    FRM_ADD editForm = new FRM_ADD();
                    FRM_ADD.id = itemId;
                    FRM_ADD.fullname = fullname;
                    editForm.txt_name.Text = item.Name;
                    editForm.txt_qun.Text = item.QuantityAvailable.ToString();
                    editForm.txt_price.Text = item.Price.ToString();
                    editForm.txt_des.Text = item.Description;
                    editForm.txt_dat.Value = item.ExpiryDate.Value;
                    editForm.btn_add.Text = "تعديل";
                    editForm.Show();
                }
                else
                {
                    DialogHelper.ShowDialog(frm, "لم يتم العثور على الصنف الذي تريد تعديله");
                }
            }
        }
        public static void EditSelectedItem( int id, FRM_ADD frm , string fullname)
        {

            try
            {
                
                using (DB_AMS_PROEntities5 db = new DB_AMS_PROEntities5())
                {
                    var item = db.Items.Find(id);
                    if (item != null)
                    {

                        bool isFieldsValid = true;
                       
                        if (string.IsNullOrEmpty(frm.txt_name.Text))
                        {
                            isFieldsValid = false;
                            mess = "يرجى إدخال الاسم";
                        }
                        else if (string.IsNullOrEmpty(frm.txt_price.Text))
                        {
                            isFieldsValid = false;
                            mess = "يرجى إدخال السعر";
                        }
                        else if (string.IsNullOrEmpty(frm.txt_qun.Text))
                        {
                            isFieldsValid = false;
                            mess = "يرجى إدخال الكمية";
                        }
                        else if (string.IsNullOrEmpty(frm.txt_dat.Text))
                        {
                            isFieldsValid = false;
                            mess = "يرجى إدخال تاريخ الصلاحية";
                        }



                        if (isFieldsValid)
                        {

                            item.Name = frm.txt_name.Text;
                            item.QuantityAvailable = Convert.ToInt32(frm.txt_qun.Text);
                            item.Price = (decimal)Convert.ToDouble(frm.txt_price.Text);
                            item.Description = frm.txt_des.Text;
                            item.ExpiryDate = Convert.ToDateTime(frm.txt_dat.Text);

                            Log log = new Log();

                            log.Edit(fullname,id);

                            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            DialogHelper.ShowDetails("تم تعديل الصنف");

                            

                        }
                        else
                        {
                            DialogHelper.ShowDialog(frm, mess);
                        }
                    }

                }
                   
            }
            catch
            {
                MessageBox.Show("no server");
            }
        }

        public static void DeleteSelectedItems(List<int> itemIds, string fullname, Form form)
        {
            using (var db = new DB_AMS_PROEntities5())
            {
                var dialogResult = MessageBox.Show("هل أنت متأكد من هذا الإجراء؟ لا يمكن استرجاع البيانات، سيتم حذف جميع البيانات المرتبطة", "إجراء الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    foreach (int itemId in itemIds)
                    {
                        var item = db.Items.FirstOrDefault(x => x.ItemID == itemId);

                        if (item != null)
                        {
                            Log log = new Log();

                            log.delete(fullname, itemId);

                            db.Items.Remove(item); // حذف العنصر من قاعدة البيانات
                        }
                    }

                    db.SaveChanges();
                    DialogHelper.ShowDialog(form, "تم حذف الصنف بنجاح");
                }
            }
        }
    }

            
  
}
