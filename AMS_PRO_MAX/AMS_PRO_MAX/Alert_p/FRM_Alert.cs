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
        Form1 frm;
        private List<int> Idlist = new List<int>();
        public FRM_Alert()
        {
            InitializeComponent();
        }

        private void FRM_Alert_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_AMS_PRODataSet4.Alerts' table. You can move, or remove it, as needed.
            this.alertsTableAdapter.Fill(this.dB_AMS_PRODataSet4.Alerts);
           
            db = new DB_AMS_PROEntities5();
            dataGridView1.DataSource = db.Alerts.ToList();

        }
        
        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            DeleteAlert();
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
                        DatabaseHelper.DeleteAlerts(Idlist);
                        DialogHelper.ShowDialog(this, "تم حذف الصنف بنجاح");
                    }
                }
                else
                {
                    DialogHelper.ShowDialog(this, "اجراء الحذف لابد لك من تحديد كامل الصف");
                }

            }
            else
            {
                MessageBox.Show("لا يوجد بيانات لحذفها", "لا يمكن إجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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


        private void refresh(object sender, EventArgs e)
        {
            frm = new Form1();
            db = new DB_AMS_PROEntities5();
            dataGridView1.DataSource = db.Alerts.ToList();
            frm.txt_cot_alert.Text = Convert.ToString(db.Alerts.Count());

        }


    }
}
