using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AMS_PRO_MAX.ItemP;
namespace AMS_PRO_MAX
{
    public partial class FRM_ADD : Form
    {
        private Cls_AddNewItem AddEdit;
        
        DB_AMS_PROEntities5 db = new DB_AMS_PROEntities5();

        

        public int id;

        public FRM_ADD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddEdit = new Cls_AddNewItem();

            AddEdit.AddAndEdit(id,this);
          
        }

    }   
    
}

