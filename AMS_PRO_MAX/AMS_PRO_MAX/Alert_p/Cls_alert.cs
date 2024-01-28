using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AMS_PRO_MAX
{
    class Cls_alert
    {
        

        public void alert()
        {
            DB_AMS_PROEntities5 db = new DB_AMS_PROEntities5();
        FRM_Alert alert = new FRM_Alert();
        Form1 main;
        dialog dialo;
            db = new DB_AMS_PROEntities5();
            dialo = new dialog();
            alert = new FRM_Alert();
            alert.dataGridView1.DataSource = db.Alerts.ToList();
            try
            {
                db = new DB_AMS_PROEntities5();

                dialo = new dialog();
                

                var today = DateTime.Now;
                var expiryThreshold = today.AddDays(60);

                var expiringItems = db.Items.Where(x => x.ExpiryDate <= expiryThreshold).ToList();

                var existingAlertNames = db.Alerts
                    .Select(x => x.ProductName)
                    .ToList();

                var newExpiringItems = expiringItems
                    .Where(x => !existingAlertNames.Contains(x.Name))
                    .ToList();

                if (newExpiringItems.Count > 0)
                {
                   
                    if (true)
                    {
        
                        var alerts = newExpiringItems.Select(item => new Alert
                        {
                            ProductName = item.Name,
                            ExpiryDate = item.ExpiryDate,
                            AvailableQuantity = item.QuantityAvailable
                        }).ToList();
                        
                        db.Alerts.AddRange(alerts);
                        db.SaveChanges();
                        db.Items.RemoveRange(newExpiringItems);
                        db.SaveChanges();

              
                        main = new Form1();
                        
                        dialo.label6.Text = "تم نقل الأصناف التي انتهت صلاحيتها إلى جدول التنبيهات  " ;
                        dialo.Show();
                    }
                }
                else
                {
                    //MessageBox.Show("لا يوجد أصناف تم انتهاء صلاحيتها", "لا يمكن إجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ في الاتصال بقاعدة البيانات: " + ex.Message, "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
