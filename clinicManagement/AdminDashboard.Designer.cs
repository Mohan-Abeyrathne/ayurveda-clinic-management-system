namespace clinicManagement
{
    partial class AdminDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnManageStaff = new System.Windows.Forms.Button();
            this.btnManageDoctors = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(944, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Admin Dashboard!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnInventory);
            this.panel2.Controls.Add(this.btnManageStaff);
            this.panel2.Controls.Add(this.btnManageDoctors);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 734);
            this.panel2.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogout.Location = new System.Drawing.Point(23, 637);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(289, 59);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "🔓 Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.Black;
            this.btnInventory.Location = new System.Drawing.Point(1, 424);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(322, 59);
            this.btnInventory.TabIndex = 7;
            this.btnInventory.Text = "💊 Herbal Pharmacy";
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnManageStaff
            // 
            this.btnManageStaff.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnManageStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageStaff.FlatAppearance.BorderSize = 0;
            this.btnManageStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStaff.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStaff.ForeColor = System.Drawing.Color.Black;
            this.btnManageStaff.Location = new System.Drawing.Point(1, 359);
            this.btnManageStaff.Name = "btnManageStaff";
            this.btnManageStaff.Size = new System.Drawing.Size(322, 59);
            this.btnManageStaff.TabIndex = 6;
            this.btnManageStaff.Text = "👥 Manage Staff";
            this.btnManageStaff.UseVisualStyleBackColor = false;
            // 
            // btnManageDoctors
            // 
            this.btnManageDoctors.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnManageDoctors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageDoctors.FlatAppearance.BorderSize = 0;
            this.btnManageDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageDoctors.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDoctors.ForeColor = System.Drawing.Color.Black;
            this.btnManageDoctors.Location = new System.Drawing.Point(1, 295);
            this.btnManageDoctors.Name = "btnManageDoctors";
            this.btnManageDoctors.Size = new System.Drawing.Size(322, 58);
            this.btnManageDoctors.TabIndex = 5;
            this.btnManageDoctors.Text = "🩺 Manage Doctors";
            this.btnManageDoctors.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Location = new System.Drawing.Point(3, 230);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(320, 59);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "🏠 Main Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.BackgroundImage = global::clinicManagement.Properties.Resources.image_removebg_preview__43_1;
            this.panel3.Location = new System.Drawing.Point(30, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 175);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 726);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashboard_FormClosed);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnManageStaff;
        private System.Windows.Forms.Button btnManageDoctors;
        private System.Windows.Forms.Button btnDashboard;
    }
}