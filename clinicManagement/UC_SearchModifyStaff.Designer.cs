namespace clinicManagement
{
    partial class UC_SearchModifyStaff
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
            this.txtSearchStaffName = new System.Windows.Forms.TextBox();
            this.dgvStaffSearchList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditStaffFullName = new System.Windows.Forms.TextBox();
            this.txtEditStaffPhone = new System.Windows.Forms.TextBox();
            this.txtEditStaffUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffSearchList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Staff by Name:";
            // 
            // txtSearchStaffName
            // 
            this.txtSearchStaffName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStaffName.Location = new System.Drawing.Point(296, 38);
            this.txtSearchStaffName.Name = "txtSearchStaffName";
            this.txtSearchStaffName.Size = new System.Drawing.Size(268, 34);
            this.txtSearchStaffName.TabIndex = 2;
            this.txtSearchStaffName.TextChanged += new System.EventHandler(this.txtSearchStaffName_TextChanged);
            // 
            // dgvStaffSearchList
            // 
            this.dgvStaffSearchList.AllowUserToAddRows = false;
            this.dgvStaffSearchList.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvStaffSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffSearchList.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvStaffSearchList.Location = new System.Drawing.Point(23, 95);
            this.dgvStaffSearchList.MultiSelect = false;
            this.dgvStaffSearchList.Name = "dgvStaffSearchList";
            this.dgvStaffSearchList.ReadOnly = true;
            this.dgvStaffSearchList.RowHeadersWidth = 51;
            this.dgvStaffSearchList.RowTemplate.Height = 24;
            this.dgvStaffSearchList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffSearchList.Size = new System.Drawing.Size(455, 500);
            this.dgvStaffSearchList.TabIndex = 3;
            this.dgvStaffSearchList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffSearchList_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnDeleteStaff);
            this.panel1.Controls.Add(this.btnUpdateStaff);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEditStaffFullName);
            this.panel1.Controls.Add(this.txtEditStaffPhone);
            this.panel1.Controls.Add(this.txtEditStaffUsername);
            this.panel1.Location = new System.Drawing.Point(494, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 500);
            this.panel1.TabIndex = 4;
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteStaff.FlatAppearance.BorderSize = 0;
            this.btnDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStaff.Location = new System.Drawing.Point(51, 312);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(119, 46);
            this.btnDeleteStaff.TabIndex = 7;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdateStaff.FlatAppearance.BorderSize = 0;
            this.btnUpdateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStaff.Location = new System.Drawing.Point(191, 312);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(119, 46);
            this.btnUpdateStaff.TabIndex = 6;
            this.btnUpdateStaff.Text = "Update";
            this.btnUpdateStaff.UseVisualStyleBackColor = false;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEditStaffFullName
            // 
            this.txtEditStaffFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditStaffFullName.Location = new System.Drawing.Point(32, 149);
            this.txtEditStaffFullName.Name = "txtEditStaffFullName";
            this.txtEditStaffFullName.Size = new System.Drawing.Size(296, 30);
            this.txtEditStaffFullName.TabIndex = 2;
            this.txtEditStaffFullName.TextChanged += new System.EventHandler(this.txtEditStaffFullName_TextChanged);
            // 
            // txtEditStaffPhone
            // 
            this.txtEditStaffPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditStaffPhone.Location = new System.Drawing.Point(32, 239);
            this.txtEditStaffPhone.Name = "txtEditStaffPhone";
            this.txtEditStaffPhone.Size = new System.Drawing.Size(296, 30);
            this.txtEditStaffPhone.TabIndex = 1;
            // 
            // txtEditStaffUsername
            // 
            this.txtEditStaffUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditStaffUsername.Location = new System.Drawing.Point(32, 66);
            this.txtEditStaffUsername.Name = "txtEditStaffUsername";
            this.txtEditStaffUsername.Size = new System.Drawing.Size(296, 30);
            this.txtEditStaffUsername.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 665);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(438, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "* Ayurveda Clinic Management System *";
            // 
            // UC_SearchModifyStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvStaffSearchList);
            this.Controls.Add(this.txtSearchStaffName);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UC_SearchModifyStaff";
            this.Size = new System.Drawing.Size(911, 735);
            this.Load += new System.EventHandler(this.UC_SearchModifyStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffSearchList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchStaffName;
        private System.Windows.Forms.DataGridView dgvStaffSearchList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditStaffFullName;
        private System.Windows.Forms.TextBox txtEditStaffPhone;
        private System.Windows.Forms.TextBox txtEditStaffUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Label label5;
    }
}
