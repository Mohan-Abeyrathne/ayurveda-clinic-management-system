namespace clinicManagement
{
    partial class ManageStaffForm
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
            this.panelLeftStaff = new System.Windows.Forms.Panel();
            this.btnCancelStaff = new System.Windows.Forms.Button();
            this.btnViewAllStaffView = new System.Windows.Forms.Button();
            this.btnSearchStaffView = new System.Windows.Forms.Button();
            this.btnAddStaffView = new System.Windows.Forms.Button();
            this.panelRightStaff = new System.Windows.Forms.Panel();
            this.panelLeftStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftStaff
            // 
            this.panelLeftStaff.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelLeftStaff.Controls.Add(this.btnCancelStaff);
            this.panelLeftStaff.Controls.Add(this.btnViewAllStaffView);
            this.panelLeftStaff.Controls.Add(this.btnSearchStaffView);
            this.panelLeftStaff.Controls.Add(this.btnAddStaffView);
            this.panelLeftStaff.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftStaff.Location = new System.Drawing.Point(0, 0);
            this.panelLeftStaff.Name = "panelLeftStaff";
            this.panelLeftStaff.Size = new System.Drawing.Size(339, 741);
            this.panelLeftStaff.TabIndex = 0;
            this.panelLeftStaff.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeftStaff_Paint);
            // 
            // btnCancelStaff
            // 
            this.btnCancelStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelStaff.Location = new System.Drawing.Point(89, 491);
            this.btnCancelStaff.Name = "btnCancelStaff";
            this.btnCancelStaff.Size = new System.Drawing.Size(137, 85);
            this.btnCancelStaff.TabIndex = 5;
            this.btnCancelStaff.Text = "❌ Close Window";
            this.btnCancelStaff.UseVisualStyleBackColor = true;
            this.btnCancelStaff.Click += new System.EventHandler(this.btnCancelStaff_Click);
            // 
            // btnViewAllStaffView
            // 
            this.btnViewAllStaffView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllStaffView.Location = new System.Drawing.Point(89, 382);
            this.btnViewAllStaffView.Name = "btnViewAllStaffView";
            this.btnViewAllStaffView.Size = new System.Drawing.Size(137, 85);
            this.btnViewAllStaffView.TabIndex = 3;
            this.btnViewAllStaffView.Text = "📋 View All Staff";
            this.btnViewAllStaffView.UseVisualStyleBackColor = true;
            this.btnViewAllStaffView.Click += new System.EventHandler(this.btnViewAllStaffView_Click);
            // 
            // btnSearchStaffView
            // 
            this.btnSearchStaffView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStaffView.Location = new System.Drawing.Point(89, 276);
            this.btnSearchStaffView.Name = "btnSearchStaffView";
            this.btnSearchStaffView.Size = new System.Drawing.Size(137, 85);
            this.btnSearchStaffView.TabIndex = 1;
            this.btnSearchStaffView.Text = "🔍 Search and Modify";
            this.btnSearchStaffView.UseVisualStyleBackColor = true;
            this.btnSearchStaffView.Click += new System.EventHandler(this.btnSearchStaffView_Click);
            // 
            // btnAddStaffView
            // 
            this.btnAddStaffView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaffView.Location = new System.Drawing.Point(89, 170);
            this.btnAddStaffView.Name = "btnAddStaffView";
            this.btnAddStaffView.Size = new System.Drawing.Size(137, 85);
            this.btnAddStaffView.TabIndex = 0;
            this.btnAddStaffView.Text = "➕ Add New Staff";
            this.btnAddStaffView.UseVisualStyleBackColor = true;
            this.btnAddStaffView.Click += new System.EventHandler(this.btnAddStaffView_Click);
            // 
            // panelRightStaff
            // 
            this.panelRightStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightStaff.Location = new System.Drawing.Point(339, 0);
            this.panelRightStaff.Name = "panelRightStaff";
            this.panelRightStaff.Size = new System.Drawing.Size(909, 741);
            this.panelRightStaff.TabIndex = 1;
            this.panelRightStaff.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRightStaff_Paint);
            // 
            // ManageStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 741);
            this.Controls.Add(this.panelRightStaff);
            this.Controls.Add(this.panelLeftStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageStaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageStaffForm";
            this.panelLeftStaff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftStaff;
        private System.Windows.Forms.Panel panelRightStaff;
        private System.Windows.Forms.Button btnViewAllStaffView;
        private System.Windows.Forms.Button btnSearchStaffView;
        private System.Windows.Forms.Button btnAddStaffView;
        private System.Windows.Forms.Button btnCancelStaff;
    }
}