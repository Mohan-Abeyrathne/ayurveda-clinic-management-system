namespace clinicManagement
{
    partial class UC_SearchModifyDoctor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDoctorSearchList = new System.Windows.Forms.DataGridView();
            this.txtEditUsername = new System.Windows.Forms.TextBox();
            this.txtEditFullName = new System.Windows.Forms.TextBox();
            this.txtEditPhone = new System.Windows.Forms.TextBox();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.txtEditLicense = new System.Windows.Forms.TextBox();
            this.txtEditSpecialization = new System.Windows.Forms.TextBox();
            this.txtEditExperience = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnDeleteDoctor = new System.Windows.Forms.Button();
            this.btnUpdateDoctor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorSearchList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = " Search Doctor by Name:";
            // 
            // dgvDoctorSearchList
            // 
            this.dgvDoctorSearchList.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDoctorSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorSearchList.Location = new System.Drawing.Point(34, 91);
            this.dgvDoctorSearchList.MultiSelect = false;
            this.dgvDoctorSearchList.Name = "dgvDoctorSearchList";
            this.dgvDoctorSearchList.ReadOnly = true;
            this.dgvDoctorSearchList.RowHeadersWidth = 51;
            this.dgvDoctorSearchList.RowTemplate.Height = 24;
            this.dgvDoctorSearchList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctorSearchList.Size = new System.Drawing.Size(463, 573);
            this.dgvDoctorSearchList.TabIndex = 2;
            this.dgvDoctorSearchList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctorSearchList_CellContentClick);
            // 
            // txtEditUsername
            // 
            this.txtEditUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditUsername.Location = new System.Drawing.Point(38, 47);
            this.txtEditUsername.Name = "txtEditUsername";
            this.txtEditUsername.Size = new System.Drawing.Size(290, 30);
            this.txtEditUsername.TabIndex = 3;
            this.txtEditUsername.TextChanged += new System.EventHandler(this.txtEditUsername_TextChanged);
            // 
            // txtEditFullName
            // 
            this.txtEditFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditFullName.Location = new System.Drawing.Point(38, 102);
            this.txtEditFullName.Name = "txtEditFullName";
            this.txtEditFullName.Size = new System.Drawing.Size(290, 30);
            this.txtEditFullName.TabIndex = 4;
            this.txtEditFullName.TextChanged += new System.EventHandler(this.txtEditFullName_TextChanged);
            // 
            // txtEditPhone
            // 
            this.txtEditPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPhone.Location = new System.Drawing.Point(38, 161);
            this.txtEditPhone.Name = "txtEditPhone";
            this.txtEditPhone.Size = new System.Drawing.Size(290, 30);
            this.txtEditPhone.TabIndex = 5;
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditEmail.Location = new System.Drawing.Point(38, 225);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(290, 30);
            this.txtEditEmail.TabIndex = 6;
            this.txtEditEmail.TextChanged += new System.EventHandler(this.txtEditEmail_TextChanged);
            // 
            // txtEditLicense
            // 
            this.txtEditLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditLicense.Location = new System.Drawing.Point(38, 284);
            this.txtEditLicense.Name = "txtEditLicense";
            this.txtEditLicense.Size = new System.Drawing.Size(290, 30);
            this.txtEditLicense.TabIndex = 7;
            // 
            // txtEditSpecialization
            // 
            this.txtEditSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSpecialization.Location = new System.Drawing.Point(38, 351);
            this.txtEditSpecialization.Name = "txtEditSpecialization";
            this.txtEditSpecialization.Size = new System.Drawing.Size(290, 30);
            this.txtEditSpecialization.TabIndex = 8;
            this.txtEditSpecialization.TextChanged += new System.EventHandler(this.txtEditSpecialization_TextChanged);
            // 
            // txtEditExperience
            // 
            this.txtEditExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditExperience.Location = new System.Drawing.Point(38, 413);
            this.txtEditExperience.Name = "txtEditExperience";
            this.txtEditExperience.Size = new System.Drawing.Size(290, 30);
            this.txtEditExperience.TabIndex = 9;
            this.txtEditExperience.TextChanged += new System.EventHandler(this.txtEditExperience_TextChanged);
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.Location = new System.Drawing.Point(278, 34);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(292, 30);
            this.txtSearchName.TabIndex = 11;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // btnDeleteDoctor
            // 
            this.btnDeleteDoctor.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteDoctor.FlatAppearance.BorderSize = 0;
            this.btnDeleteDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDoctor.Location = new System.Drawing.Point(38, 467);
            this.btnDeleteDoctor.Name = "btnDeleteDoctor";
            this.btnDeleteDoctor.Size = new System.Drawing.Size(136, 46);
            this.btnDeleteDoctor.TabIndex = 12;
            this.btnDeleteDoctor.Text = "Delete Profile";
            this.btnDeleteDoctor.UseVisualStyleBackColor = false;
            this.btnDeleteDoctor.Click += new System.EventHandler(this.btnDeleteDoctor_Click);
            // 
            // btnUpdateDoctor
            // 
            this.btnUpdateDoctor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdateDoctor.FlatAppearance.BorderSize = 0;
            this.btnUpdateDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDoctor.Location = new System.Drawing.Point(180, 467);
            this.btnUpdateDoctor.Name = "btnUpdateDoctor";
            this.btnUpdateDoctor.Size = new System.Drawing.Size(148, 46);
            this.btnUpdateDoctor.TabIndex = 13;
            this.btnUpdateDoctor.Text = "Update Profile";
            this.btnUpdateDoctor.UseVisualStyleBackColor = false;
            this.btnUpdateDoctor.Click += new System.EventHandler(this.btnUpdateDoctor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnUpdateDoctor);
            this.panel1.Controls.Add(this.btnDeleteDoctor);
            this.panel1.Controls.Add(this.txtEditUsername);
            this.panel1.Controls.Add(this.txtEditFullName);
            this.panel1.Controls.Add(this.txtEditPhone);
            this.panel1.Controls.Add(this.txtEditEmail);
            this.panel1.Controls.Add(this.txtEditLicense);
            this.panel1.Controls.Add(this.txtEditSpecialization);
            this.panel1.Controls.Add(this.txtEditExperience);
            this.panel1.Location = new System.Drawing.Point(515, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 573);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 691);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "* Ayurveda Clinic Management System *";
            // 
            // UC_SearchModifyDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.dgvDoctorSearchList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UC_SearchModifyDoctor";
            this.Size = new System.Drawing.Size(922, 735);
            this.Load += new System.EventHandler(this.UC_SearchModifyDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorSearchList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDoctorSearchList;
        private System.Windows.Forms.TextBox txtEditUsername;
        private System.Windows.Forms.TextBox txtEditFullName;
        private System.Windows.Forms.TextBox txtEditPhone;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.TextBox txtEditLicense;
        private System.Windows.Forms.TextBox txtEditSpecialization;
        private System.Windows.Forms.TextBox txtEditExperience;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnDeleteDoctor;
        private System.Windows.Forms.Button btnUpdateDoctor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}
