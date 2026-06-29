namespace clinicManagement
{
    partial class DashboardHomeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPatientTitle = new System.Windows.Forms.Label();
            this.lblTotalPatientsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDoctorTitle = new System.Windows.Forms.Label();
            this.lblTotalDoctorsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblStaffTitle = new System.Windows.Forms.Label();
            this.lblTotalStaffCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblInventoryTitle = new System.Windows.Forms.Label();
            this.lblLowStockCount = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.BackgroundImage = global::clinicManagement.Properties.Resources.patient_cd;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblPatientTitle);
            this.panel1.Controls.Add(this.lblTotalPatientsCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(82, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 325);
            this.panel1.TabIndex = 0;
            // 
            // lblPatientTitle
            // 
            this.lblPatientTitle.AutoSize = true;
            this.lblPatientTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientTitle.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientTitle.Location = new System.Drawing.Point(3, 189);
            this.lblPatientTitle.Name = "lblPatientTitle";
            this.lblPatientTitle.Size = new System.Drawing.Size(198, 17);
            this.lblPatientTitle.TabIndex = 1;
            this.lblPatientTitle.Text = "Registered Patients";
            // 
            // lblTotalPatientsCount
            // 
            this.lblTotalPatientsCount.AutoSize = true;
            this.lblTotalPatientsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPatientsCount.Font = new System.Drawing.Font("Sitka Banner", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPatientsCount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPatientsCount.Location = new System.Drawing.Point(128, 206);
            this.lblTotalPatientsCount.Name = "lblTotalPatientsCount";
            this.lblTotalPatientsCount.Size = new System.Drawing.Size(61, 87);
            this.lblTotalPatientsCount.TabIndex = 0;
            this.lblTotalPatientsCount.Text = "1";
            this.lblTotalPatientsCount.Click += new System.EventHandler(this.lblTotalPatientsCount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(76, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 87);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 87);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.BackgroundImage = global::clinicManagement.Properties.Resources.doc_cd1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblDoctorTitle);
            this.panel2.Controls.Add(this.lblTotalDoctorsCount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(382, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 326);
            this.panel2.TabIndex = 1;
            // 
            // lblDoctorTitle
            // 
            this.lblDoctorTitle.AutoSize = true;
            this.lblDoctorTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctorTitle.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorTitle.Location = new System.Drawing.Point(24, 184);
            this.lblDoctorTitle.Name = "lblDoctorTitle";
            this.lblDoctorTitle.Size = new System.Drawing.Size(174, 20);
            this.lblDoctorTitle.TabIndex = 2;
            this.lblDoctorTitle.Text = "On-Duty Doctors";
            // 
            // lblTotalDoctorsCount
            // 
            this.lblTotalDoctorsCount.AutoSize = true;
            this.lblTotalDoctorsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDoctorsCount.Font = new System.Drawing.Font("Sitka Banner", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDoctorsCount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalDoctorsCount.Location = new System.Drawing.Point(105, 206);
            this.lblTotalDoctorsCount.Name = "lblTotalDoctorsCount";
            this.lblTotalDoctorsCount.Size = new System.Drawing.Size(67, 87);
            this.lblTotalDoctorsCount.TabIndex = 1;
            this.lblTotalDoctorsCount.Text = "2";
            this.lblTotalDoctorsCount.Click += new System.EventHandler(this.lblTotalDoctorsCount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(58, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 87);
            this.label3.TabIndex = 4;
            this.label3.Text = "0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.BackgroundImage = global::clinicManagement.Properties.Resources.staff_cd1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblStaffTitle);
            this.panel3.Controls.Add(this.lblTotalStaffCount);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(684, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 325);
            this.panel3.TabIndex = 0;
            // 
            // lblStaffTitle
            // 
            this.lblStaffTitle.AutoSize = true;
            this.lblStaffTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffTitle.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffTitle.Location = new System.Drawing.Point(17, 195);
            this.lblStaffTitle.Name = "lblStaffTitle";
            this.lblStaffTitle.Size = new System.Drawing.Size(185, 20);
            this.lblStaffTitle.TabIndex = 2;
            this.lblStaffTitle.Text = "Front-Desk Staff";
            // 
            // lblTotalStaffCount
            // 
            this.lblTotalStaffCount.AutoSize = true;
            this.lblTotalStaffCount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalStaffCount.Font = new System.Drawing.Font("Sitka Banner", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStaffCount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalStaffCount.Location = new System.Drawing.Point(114, 215);
            this.lblTotalStaffCount.Name = "lblTotalStaffCount";
            this.lblTotalStaffCount.Size = new System.Drawing.Size(67, 87);
            this.lblTotalStaffCount.TabIndex = 1;
            this.lblTotalStaffCount.Text = "3";
            this.lblTotalStaffCount.Click += new System.EventHandler(this.lblTotalStaffCount_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(64, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 87);
            this.label5.TabIndex = 6;
            this.label5.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleGreen;
            this.panel4.BackgroundImage = global::clinicManagement.Properties.Resources.medi_cd1;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblInventoryTitle);
            this.panel4.Controls.Add(this.lblLowStockCount);
            this.panel4.Location = new System.Drawing.Point(82, 396);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 310);
            this.panel4.TabIndex = 2;
            // 
            // lblInventoryTitle
            // 
            this.lblInventoryTitle.AutoSize = true;
            this.lblInventoryTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblInventoryTitle.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryTitle.ForeColor = System.Drawing.Color.Red;
            this.lblInventoryTitle.Location = new System.Drawing.Point(16, 186);
            this.lblInventoryTitle.Name = "lblInventoryTitle";
            this.lblInventoryTitle.Size = new System.Drawing.Size(185, 20);
            this.lblInventoryTitle.TabIndex = 3;
            this.lblInventoryTitle.Text = "Low Stock Alerts";
            // 
            // lblLowStockCount
            // 
            this.lblLowStockCount.AutoSize = true;
            this.lblLowStockCount.BackColor = System.Drawing.Color.Transparent;
            this.lblLowStockCount.Font = new System.Drawing.Font("Sitka Banner", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStockCount.ForeColor = System.Drawing.Color.Red;
            this.lblLowStockCount.Location = new System.Drawing.Point(76, 196);
            this.lblLowStockCount.Name = "lblLowStockCount";
            this.lblLowStockCount.Size = new System.Drawing.Size(69, 87);
            this.lblLowStockCount.TabIndex = 1;
            this.lblLowStockCount.Text = "4";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(788, 628);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 78);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "🔙";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBackToHome_Click_1);
            // 
            // DashboardHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::clinicManagement.Properties.Resources.bg_admin_panel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1160, 744);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "DashboardHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DashboardHomeForm";
            this.Load += new System.EventHandler(this.DashboardHomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalPatientsCount;
        private System.Windows.Forms.Label lblTotalDoctorsCount;
        private System.Windows.Forms.Label lblPatientTitle;
        private System.Windows.Forms.Label lblDoctorTitle;
        private System.Windows.Forms.Label lblStaffTitle;
        private System.Windows.Forms.Label lblTotalStaffCount;
        private System.Windows.Forms.Label lblInventoryTitle;
        private System.Windows.Forms.Label lblLowStockCount;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}