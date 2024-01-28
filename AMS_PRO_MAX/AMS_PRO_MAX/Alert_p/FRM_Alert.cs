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
    public partial class FRM_Alert : Form
    {
        
        Cls_alert d = new Cls_alert();
        DB_AMS_PROEntities5 db;
        dialog dialo;
        Form1 frm;
        private List<int> Idlist = new List<int>();
        public FRM_Alert()
        {
            InitializeComponent();
        }

        private void FRM_Alert_Load(object sender, EventArgs e)
        {
            this.alertsTableAdapter.Fill(this.dB_AMS_PRODataSet2.Alerts);
            db = new DB_AMS_PROEntities5();
            dataGridView1.DataSource = db.Alerts.ToList();

        }
        
        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            DeleteAlert();
        }
     
        private void SelectRowForDelete()
        {
            Idlist.Clear();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    Idlist.Add(Convert.ToInt32(row.Cells[0].Value));
                }
            }


        }
        private void DeleteAlert()
        {
            if (dataGridView1.RowCount > 0)
            {
                SelectRowForDelete();
                if (Idlist.Count > 0)
                {
                    var dialogResult = MessageBox.Show("هل أنت متأكد من هذا الإجراء؟ لا يمكن استرجاع البيانات، سيتم حذف جميع البيانات المرتبطة", "إجراء الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        db = new DB_AMS_PROEntities5();
                        foreach (int id in Idlist)
                        {
                            var add = db.Alerts.FirstOrDefault(x => x.AlertID == id);

                            if (add != null)
                            {
                                db.Alerts.Remove(add); // حذف العنصر من قاعدة البيانات

                            }
                        }
                        db.SaveChanges();

                        dialo = new dialog();
                        dialo.label6.Text = "تم حذف الصنف بنجاح";
                        dialo.Show();


                    }
                    else
                    {

                    }
                }
                else
                {
                    dialo = new dialog();
                    dialo.label6.Text = "اجراء الحذف لابد لك من تحديد كامل الصف";
                    dialo.Show();
                }

            }
            else
            {
                MessageBox.Show("لا يوجد بيانات لحذفها", "لا يمكن إجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refresh(object sender, EventArgs e)
        {
            frm = new Form1();
            db = new DB_AMS_PROEntities5();
            dataGridView1.DataSource = db.Alerts.ToList();
            frm.txt_cot_alert.Text = Convert.ToString(db.Alerts.Count());

        }


    }
}
