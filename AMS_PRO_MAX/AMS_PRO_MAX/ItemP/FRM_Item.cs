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
using AMS_PRO_MAX.ItemP;
using AMS_PRO_MAX.Logs;
namespace AMS_PRO_MAX
{
    public partial class FRM_HOME : Form
    {
        private List<int> Idlist = new List<int>();
        Form1 frm;
        //FRM_ADD eidt;
        DB_AMS_PROEntities6 db;
        Log log;
        
        
        User User  = new User();
        string fullname;
        public FRM_HOME()
        {
            InitializeComponent();
          

        }
        public FRM_HOME(string user1)
        {
            InitializeComponent();
           
            
            fullname = user1;


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
            // TODO: This line of code loads data into the 'dB_AMS_PRODataSet4.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter1.Fill(this.dB_AMS_PRODataSet4.Items);
            // TODO: This line of code loads data into the 'dB_AMS_PRODataSet4.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter1.Fill(this.dB_AMS_PRODataSet4.Items);
          

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void itemsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            db = new DB_AMS_PROEntities6();
            dataGridView1.DataSource = db.Items.ToList();
            frm = new Form1();
            frm.txt_cot_alert.Text = Convert.ToString(db.Alerts.Count());

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            delete();

        }
        private void delete()
        {
            try
            {
                if (dataGridView1.RowCount > 0)
                {

                    SelectRowForDelete();
                    if (Idlist.Count > 0)
                    {
                        DatabaseHelper.DeleteSelectedItems(Idlist, fullname, this);

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
            catch
            {
                MessageBox.Show("لا يمكن إجراء العملية");
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

        private void btn_sear_Click(object sender, EventArgs e)
        {
            var searchTerm = txt_sear.Text;
            dataGridView1.DataSource = DatabaseHelper.SearchItems(searchTerm); ;
        }

        private void btn_eidit_Click(object sender, EventArgs e)
        {
            eidit();
        }

       
        private void eidit()
        {
            if (dataGridView1.RowCount > 0)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                DatabaseHelper.EditShow(id, this,fullname);

            }
            else
            {
                MessageBox.Show("لا يوجد بيانات لتعديلها", "لا يمكن إجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dBAMSPRODataSet21BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}