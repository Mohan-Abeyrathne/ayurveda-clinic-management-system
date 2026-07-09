namespace clinicManagement
{
    partial class UC_AddStaff
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
            this.groupStaffAccount = new System.Windows.Forms.GroupBox();
            this.txtStaffPhone = new System.Windows.Forms.TextBox();
            this.txtStaffFullName = new System.Windows.Forms.TextBox();
            this.txtStaffPassword = new System.Windows.Forms.TextBox();
            this.txtStaffUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveStaff = new System.Windows.Forms.Button();
            this.btnClearStaffFields = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupStaffAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupStaffAccount
            // 
            this.groupStaffAccount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupStaffAccount.Controls.Add(this.txtStaffPhone);
            this.groupStaffAccount.Controls.Add(this.txtStaffFullName);
            this.groupStaffAccount.Controls.Add(this.txtStaffPassword);
            this.groupStaffAccount.Controls.Add(this.txtStaffUsername);
            this.groupStaffAccount.Controls.Add(this.label4);
            this.groupStaffAccount.Controls.Add(this.label3);
            this.groupStaffAccount.Controls.Add(this.label2);
            this.groupStaffAccount.Controls.Add(this.label1);
            this.groupStaffAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupStaffAccount.Location = new System.Drawing.Point(113, 89);
            this.groupStaffAccount.Name = "groupStaffAccount";
            this.groupStaffAccount.Size = new System.Drawing.Size(596, 375);
            this.groupStaffAccount.TabIndex = 0;
            this.groupStaffAccount.TabStop = false;
            this.groupStaffAccount.Text = "📋 Staff Member Account Registration";
            // 
            // txtStaffPhone
            // 
            this.txtStaffPhone.Location = new System.Drawing.Point(292, 271);
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.Size = new System.Drawing.Size(243, 34);
            this.txtStaffPhone.TabIndex = 7;
            // 
            // txtStaffFullName
            // 
            this.txtStaffFullName.Location = new System.Drawing.Point(292, 200);
            this.txtStaffFullName.Name = "txtStaffFullName";
            this.txtStaffFullName.Size = new System.Drawing.Size(243, 34);
            this.txtStaffFullName.TabIndex = 6;
            // 
            // txtStaffPassword
            // 
            this.txtStaffPassword.Location = new System.Drawing.Point(292, 134);
            this.txtStaffPassword.Name = "txtStaffPassword";
            this.txtStaffPassword.Size = new System.Drawing.Size(243, 34);
            this.txtStaffPassword.TabIndex = 5;
            // 
            // txtStaffUsername
            // 
            this.txtStaffUsername.Location = new System.Drawing.Point(292, 71);
            this.txtStaffUsername.Name = "txtStaffUsername";
            this.txtStaffUsername.Size = new System.Drawing.Size(243, 34);
            this.txtStaffUsername.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Username:";
            // 
            // btnSaveStaff
            // 
            this.btnSaveStaff.BackColor = System.Drawing.Color.LightGreen;
            this.btnSaveStaff.FlatAppearance.BorderSize = 0;
            this.btnSaveStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStaff.Location = new System.Drawing.Point(587, 497);
            this.btnSaveStaff.Name = "btnSaveStaff";
            this.btnSaveStaff.Size = new System.Drawing.Size(122, 47);
            this.btnSaveStaff.TabIndex = 1;
            this.btnSaveStaff.Text = "Save";
            this.btnSaveStaff.UseVisualStyleBackColor = false;
            this.btnSaveStaff.Click += new System.EventHandler(this.btnSaveStaff_Click);
            // 
            // btnClearStaffFields
            // 
            this.btnClearStaffFields.BackColor = System.Drawing.Color.LightGray;
            this.btnClearStaffFields.FlatAppearance.BorderSize = 0;
            this.btnClearStaffFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearStaffFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearStaffFields.ForeColor = System.Drawing.Color.Red;
            this.btnClearStaffFields.Location = new System.Drawing.Point(433, 497);
            this.btnClearStaffFields.Name = "btnClearStaffFields";
            this.btnClearStaffFields.Size = new System.Drawing.Size(129, 47);
            this.btnClearStaffFields.TabIndex = 2;
            this.btnClearStaffFields.Text = "Clear Fields";
            this.btnClearStaffFields.UseVisualStyleBackColor = false;
            this.btnClearStaffFields.Click += new System.EventHandler(this.btnClearStaffFields_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 651);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(438, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "* Ayurveda Clinic Management System *";
            // 
            // UC_AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClearStaffFields);
            this.Controls.Add(this.btnSaveStaff);
            this.Controls.Add(this.groupStaffAccount);
            this.Name = "UC_AddStaff";
            this.Size = new System.Drawing.Size(821, 735);
            this.Load += new System.EventHandler(this.UC_AddStaff_Load);
            this.groupStaffAccount.ResumeLayout(false);
            this.groupStaffAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupStaffAccount;
        private System.Windows.Forms.TextBox txtStaffUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStaffPhone;
        private System.Windows.Forms.TextBox txtStaffFullName;
        private System.Windows.Forms.TextBox txtStaffPassword;
        private System.Windows.Forms.Button btnSaveStaff;
        private System.Windows.Forms.Button btnClearStaffFields;
        private System.Windows.Forms.Label label5;
    }
}
