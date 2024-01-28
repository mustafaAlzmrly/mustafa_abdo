using AMS_PRO_MAX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using AMS_PRO_MAX.ItemP;

namespace AMS_PRO_MAX.ItemP
{
    public class Cls_AddNewItem
    {
        
        public Cls_AddNewItem()
        {
           
        }
        public void AddAndEdit(int id,FRM_ADD frm)
        {
            DB_AMS_PROEntities5 db = new DB_AMS_PROEntities5();
            Item tb_item=new Item();
            //FRM_ADD frm = new FRM_ADD();
            Form1 form;
            dialog dialog = new dialog();
            details details = new details();
            try
            {
                if (frm.txt_name.Text == "")
                {
                    dialog.Width = frm.Width;
                    dialog.label6.Text = "اسم الصنف مطلوب";
                    dialog.Show();
                }
                else
                {

                    if (id == 0)
                    {
                        // Add
                        if (string.IsNullOrEmpty(frm.txt_name.Text) || string.IsNullOrEmpty(frm.txt_price.Text) ||
                            string.IsNullOrEmpty(frm.txt_qun.Text) || string.IsNullOrEmpty(frm.txt_dat.Text))
                        {
                            dialog.Width = frm.Width;
                            dialog.label6.Text = "يرجى ملء جميع الحقول";
                            dialog.Show();
                        }
                        else
                        {
                            var existingItem = db.Items.FirstOrDefault(item => item.Name == frm.txt_name.Text);
                            if (existingItem != null)
                            {
                                dialog.Width = frm.Width;
                                dialog.label6.Text = "اسم الصنف مكرر";
                                dialog.Show();
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
                                details.txt_det.Text = "تم اضافة صنف";
                                details.Show();
                                // تحديث عدد الاشعارات
                                form = new Form1();
                                form.txt_cot_alert.Text = Convert.ToString(db.Alerts.Count());
                            }
                        }



                    }
                    else
                    {
                        // Edit
                        var item = db.Items.Find(id);
                        if (item != null)
                        {
                            bool isFieldsValid = true;

                            if (string.IsNullOrEmpty(frm.txt_name.Text))
                            {
                                isFieldsValid = false;
                                dialog.label6.Text = "يرجى إدخال الاسم";
                            }

                            if (string.IsNullOrEmpty(frm.txt_price.Text))
                            {
                                isFieldsValid = false;
                                dialog.label6.Text = "يرجى إدخال السعر";
                            }

                            if (string.IsNullOrEmpty(frm.txt_qun.Text))
                            {
                                isFieldsValid = false;
                                dialog.label6.Text = "يرجى إدخال الكمية";
                            }

                            if (string.IsNullOrEmpty(frm.txt_dat.Text))
                            {
                                isFieldsValid = false;
                                dialog.label6.Text = "يرجى إدخال تاريخ الصلاحية";
                            }

                            if (isFieldsValid)
                            {
                                item.Name = frm.txt_name.Text;
                                item.QuantityAvailable = Convert.ToInt32(frm.txt_qun.Text);
                                item.Price = Convert.ToInt32(frm.txt_price.Text);
                                item.Description = frm.txt_des.Text;
                                item.ExpiryDate = Convert.ToDateTime(frm.txt_dat.Text);

                                db.SaveChanges();
                                details.txt_det.Text = "تم تعديل الصنف";
                                details.Show();
                            }
                            else
                            {
                                dialog.Width = frm.Width;
                                dialog.Show();
                            }
                        }
                        else
                        {
                            dialog.Width = frm.Width;
                            dialog.label6.Text = "الصنف غير موجود";
                            dialog.Show();
                        }
                    }
                }
            }
            catch
            {

            }
        }
    }
}