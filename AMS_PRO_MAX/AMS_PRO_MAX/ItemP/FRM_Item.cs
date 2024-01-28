using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace AMS_PRO_MAX
{
    public partial class FRM_HOME : Form
    {
        private List<int> Idlist = new List<int>();
        Form1 frm;
        //FRM_ADD eidt;
        DB_AMS_PROEntities5 db;
        dialog dialo;
        public int id;
        public FRM_HOME()
        {
            InitializeComponent();


        }



        private void button1_Click(object sender, EventArgs e)
        {

            FRM_ADD fadd = new FRM_ADD();
            fadd.Show();
        }

        private void pn_cat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRM_HOME_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_AMS_PRODataSet2.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.dB_AMS_PRODataSet2.Items);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void itemsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            db = new DB_AMS_PROEntities5();
            dataGridView1.DataSource = db.Items.ToList();
            frm = new Form1();
            frm.txt_cot_alert.Text = Convert.ToString(db.Alerts.Count());

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            delete();

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



        private void btn_eidit_Click(object sender, EventArgs e)
        {
            eidit();
        }

        private void btn_sear_Click(object sender, EventArgs e)
        {
            var searchTerm = txt_sear.Text;
            db = new DB_AMS_PROEntities5();
            var searchResults = db.Items.Where(item =>
            item.Name.ToString().Contains(searchTerm) ||
            item.ItemID.ToString().Contains(searchTerm) ||
            item.ExpiryDate.ToString().Contains(searchTerm) ||
            item.QuantityAvailable.ToString().Contains(searchTerm) ||
            item.Description.ToString().Contains(searchTerm) ||
            item.Price.ToString().Contains(searchTerm)
            ).ToList();
            dataGridView1.DataSource = searchResults;
        }
        private void eidit()
        {
            if (dataGridView1.RowCount > 0)
            {
                db = new DB_AMS_PROEntities5();
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var item = db.Items.Find(id);
                if (item != null)
                {
                    FRM_ADD editForm = new FRM_ADD();
                    editForm.id = id;
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
                    dialo = new dialog();
                    dialo.label6.Text = "لم يتم العتور على الصنف الدي تريد تعديله";
                    dialo.Show();


                }

            }
            else
            {
                MessageBox.Show("لا يوجد بيانات لتعديلها", "لا يمكن إجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        private void delete()
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
                            var add = db.Items.FirstOrDefault(x => x.ItemID == id);

                            if (add != null)
                            {
                                db.Items.Remove(add); // حذف العنصر من قاعدة البيانات

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}