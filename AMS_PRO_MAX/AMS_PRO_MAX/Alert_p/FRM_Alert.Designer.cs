
namespace AMS_PRO_MAX
{
    partial class FRM_Alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Alert));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alertsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_AMS_PRODataSet4 = new AMS_PRO_MAX.DB_AMS_PRODataSet4();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.alertsTableAdapter = new AMS_PRO_MAX.DB_AMS_PRODataSet4TableAdapters.AlertsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_AMS_PRODataSet4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.productNameDataGridViewTextBoxColumn,
            this.expiryDateDataGridViewTextBoxColumn,
            this.availableQuantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alertsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.MediumSpringGreen;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(659, 627);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "AlertID";
            this.Column1.HeaderText = "معرف التنبيه";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 119;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "اسم الصنف";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 280;
            // 
            // expiryDateDataGridViewTextBoxColumn
            // 
            this.expiryDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.HeaderText = "تاريخ الصلاحية";
            this.expiryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
            // 
            // availableQuantityDataGridViewTextBoxColumn
            // 
            this.availableQuantityDataGridViewTextBoxColumn.DataPropertyName = "AvailableQuantity";
            this.availableQuantityDataGridViewTextBoxColumn.HeaderText = "الكمية";
            this.availableQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.availableQuantityDataGridViewTextBoxColumn.Name = "availableQuantityDataGridViewTextBoxColumn";
            // 
            // alertsBindingSource
            // 
            this.alertsBindingSource.DataMember = "Alerts";
            this.alertsBindingSource.DataSource = this.dB_AMS_PRODataSet4;
            // 
            // dB_AMS_PRODataSet4
            // 
            this.dB_AMS_PRODataSet4.DataSetName = "DB_AMS_PRODataSet4";
            this.dB_AMS_PRODataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 504);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 123);
            this.panel1.TabIndex = 1;
            // 
            // btn_delete
            // 
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_delete.Image = global::AMS_PRO_MAX.Properties.Resources.cancel_32x32;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.Location = new System.Drawing.Point(0, 0);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(274, 123);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "حذف";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Image = global::AMS_PRO_MAX.Properties.Resources.convert_32x32;
            this.button1.Location = new System.Drawing.Point(338, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 123);
            this.button1.TabIndex = 9;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.refresh);
            // 
            // alertsTableAdapter
            // 
            this.alertsTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 627);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1523, 1365);
            this.Name = "FRM_Alert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التنبيهات";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Alert_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Alert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_AMS_PRODataSet4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btn_delete;
        private DB_AMS_PRODataSet4 dB_AMS_PRODataSet4;
        private System.Windows.Forms.BindingSource alertsBindingSource;
        private DB_AMS_PRODataSet4TableAdapters.AlertsTableAdapter alertsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableQuantityDataGridViewTextBoxColumn;
    }
}