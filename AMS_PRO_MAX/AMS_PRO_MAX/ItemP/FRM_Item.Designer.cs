
namespace AMS_PRO_MAX
{
    partial class FRM_HOME
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pn_cat = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_AMS_PRODataSet2 = new AMS_PRO_MAX.DB_AMS_PRODataSet2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_eidit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_sear = new System.Windows.Forms.TextBox();
            this.btn_sear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new AMS_PRO_MAX.DB_AMS_PRODataSet2TableAdapters.ItemsTableAdapter();
            this.pn_cat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_AMS_PRODataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_cat
            // 
            this.pn_cat.Controls.Add(this.dataGridView1);
            this.pn_cat.Controls.Add(this.panel1);
            this.pn_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_cat.Location = new System.Drawing.Point(0, 0);
            this.pn_cat.Name = "pn_cat";
            this.pn_cat.Size = new System.Drawing.Size(1266, 713);
            this.pn_cat.TabIndex = 1;
            this.pn_cat.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_cat_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityAvailableDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.expiryDateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemsBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1266, 623);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "معرف الصنف";
            this.itemIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "اسم الصنف";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 210;
            // 
            // quantityAvailableDataGridViewTextBoxColumn
            // 
            this.quantityAvailableDataGridViewTextBoxColumn.DataPropertyName = "QuantityAvailable";
            this.quantityAvailableDataGridViewTextBoxColumn.HeaderText = "الكمية";
            this.quantityAvailableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityAvailableDataGridViewTextBoxColumn.Name = "quantityAvailableDataGridViewTextBoxColumn";
            this.quantityAvailableDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityAvailableDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "السعر";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // expiryDateDataGridViewTextBoxColumn
            // 
            this.expiryDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.HeaderText = "تاريخ الانتهاء";
            this.expiryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
            this.expiryDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.expiryDateDataGridViewTextBoxColumn.Width = 140;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "الوصف";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "Items";
            this.itemsBindingSource1.DataSource = this.dB_AMS_PRODataSet2;
            // 
            // dB_AMS_PRODataSet2
            // 
            this.dB_AMS_PRODataSet2.DataSetName = "DB_AMS_PRODataSet2";
            this.dB_AMS_PRODataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_eidit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 623);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 90);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::AMS_PRO_MAX.Properties.Resources.icons8_add_38px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1043, 7);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(200, 76);
            this.button1.TabIndex = 3;
            this.button1.Text = "اضافة";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_eidit
            // 
            this.btn_eidit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eidit.Image = global::AMS_PRO_MAX.Properties.Resources.icons8_edit_38px;
            this.btn_eidit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eidit.Location = new System.Drawing.Point(837, 7);
            this.btn_eidit.Name = "btn_eidit";
            this.btn_eidit.Padding = new System.Windows.Forms.Padding(3);
            this.btn_eidit.Size = new System.Drawing.Size(200, 76);
            this.btn_eidit.TabIndex = 4;
            this.btn_eidit.Text = "تعديل";
            this.btn_eidit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eidit.UseVisualStyleBackColor = true;
            this.btn_eidit.Click += new System.EventHandler(this.btn_eidit_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_sear);
            this.panel2.Controls.Add(this.btn_sear);
            this.panel2.Location = new System.Drawing.Point(69, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(401, 64);
            this.panel2.TabIndex = 9;
            // 
            // txt_sear
            // 
            this.txt_sear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_sear.Font = new System.Drawing.Font("Segoe UI", 23F);
            this.txt_sear.Location = new System.Drawing.Point(3, 3);
            this.txt_sear.Name = "txt_sear";
            this.txt_sear.Size = new System.Drawing.Size(331, 58);
            this.txt_sear.TabIndex = 4;
            // 
            // btn_sear
            // 
            this.btn_sear.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_sear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_sear.FlatAppearance.BorderSize = 0;
            this.btn_sear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sear.Image = global::AMS_PRO_MAX.Properties.Resources.icons8_search_38px;
            this.btn_sear.Location = new System.Drawing.Point(334, 3);
            this.btn_sear.Margin = new System.Windows.Forms.Padding(0);
            this.btn_sear.Name = "btn_sear";
            this.btn_sear.Size = new System.Drawing.Size(62, 56);
            this.btn_sear.TabIndex = 8;
            this.btn_sear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sear.UseVisualStyleBackColor = false;
            this.btn_sear.Click += new System.EventHandler(this.btn_sear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Image = global::AMS_PRO_MAX.Properties.Resources.icons8_delete_38px;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(631, 7);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(3);
            this.btn_delete.Size = new System.Drawing.Size(200, 76);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "حذف";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Image = global::AMS_PRO_MAX.Properties.Resources.icons8_rotate_right_38px;
            this.button4.Location = new System.Drawing.Point(476, 7);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(3);
            this.button4.Size = new System.Drawing.Size(149, 76);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.dB_AMS_PRODataSet2;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 713);
            this.Controls.Add(this.pn_cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_HOME";
            this.Text = "FRM_HOME";
            this.Load += new System.EventHandler(this.FRM_HOME_Load);
            this.pn_cat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_AMS_PRODataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_cat;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button btn_delete;
        public System.Windows.Forms.Button btn_eidit;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txt_sear;
        public System.Windows.Forms.DataGridView dataGridView1;
        private DB_AMS_PRODataSet2 dB_AMS_PRODataSet2;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private DB_AMS_PRODataSet2TableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btn_sear;
    }
}