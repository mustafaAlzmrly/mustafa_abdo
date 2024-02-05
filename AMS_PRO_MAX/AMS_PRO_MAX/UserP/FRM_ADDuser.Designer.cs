
namespace AMS_PRO_MAX
{
    partial class FRM_ADDuser
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_password = new System.Windows.Forms.TextBox();
            this.edt_username = new System.Windows.Forms.TextBox();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_saveUser = new System.Windows.Forms.Button();
            this.btn_saveAndClose = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(189, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "كلمة السر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(189, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "اسم المستخدم";
            // 
            // edt_password
            // 
            this.edt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_password.Location = new System.Drawing.Point(22, 253);
            this.edt_password.Name = "edt_password";
            this.edt_password.Size = new System.Drawing.Size(474, 34);
            this.edt_password.TabIndex = 6;
            this.edt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edt_username
            // 
            this.edt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_username.Location = new System.Drawing.Point(22, 164);
            this.edt_username.Name = "edt_username";
            this.edt_username.Size = new System.Drawing.Size(474, 34);
            this.edt_username.TabIndex = 7;
            this.edt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edt_name
            // 
            this.edt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name.Location = new System.Drawing.Point(22, 82);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(474, 34);
            this.edt_name.TabIndex = 8;
            this.edt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(189, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "الاسم الكامل";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_saveUser);
            this.panel1.Controls.Add(this.btn_saveAndClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 81);
            this.panel1.TabIndex = 9;
            // 
            // btn_saveUser
            // 
            this.btn_saveUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_saveUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveUser.Image = global::AMS_PRO_MAX.Properties.Resources.icons8_save_40px;
            this.btn_saveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saveUser.Location = new System.Drawing.Point(361, 0);
            this.btn_saveUser.Name = "btn_saveUser";
            this.btn_saveUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_saveUser.Size = new System.Drawing.Size(155, 81);
            this.btn_saveUser.TabIndex = 11;
            this.btn_saveUser.Text = "اضافة";
            this.btn_saveUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_saveUser.UseVisualStyleBackColor = true;
            this.btn_saveUser.Click += new System.EventHandler(this.btn_saveUser_Click);
            // 
            // btn_saveAndClose
            // 
            this.btn_saveAndClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_saveAndClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveAndClose.Image = global::AMS_PRO_MAX.Properties.Resources.icons8_save_45px;
            this.btn_saveAndClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saveAndClose.Location = new System.Drawing.Point(0, 0);
            this.btn_saveAndClose.Name = "btn_saveAndClose";
            this.btn_saveAndClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_saveAndClose.Size = new System.Drawing.Size(180, 81);
            this.btn_saveAndClose.TabIndex = 10;
            this.btn_saveAndClose.Text = "حفظ واغلاق";
            this.btn_saveAndClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_saveAndClose.UseVisualStyleBackColor = true;
            this.btn_saveAndClose.Click += new System.EventHandler(this.btn_saveAndClose_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "مدير",
            "موظف"});
            this.comboBox1.Location = new System.Drawing.Point(359, 316);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 32);
            this.comboBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(189, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "الوظيفة";
            // 
            // FRM_ADDuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(516, 460);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edt_password);
            this.Controls.Add(this.edt_username);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_ADDuser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADDuser";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox edt_password;
        public System.Windows.Forms.TextBox edt_username;
        public System.Windows.Forms.TextBox edt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btn_saveAndClose;
        public System.Windows.Forms.Button btn_saveUser;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}