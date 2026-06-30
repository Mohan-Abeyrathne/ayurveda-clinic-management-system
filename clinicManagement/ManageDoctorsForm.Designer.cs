namespace clinicManagement
{
    partial class ManageDoctorsForm
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnViewAllView = new System.Windows.Forms.Button();
            this.btnSearchView = new System.Windows.Forms.Button();
            this.btnAddDoctorView = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelLeft.Controls.Add(this.btnCancel);
            this.panelLeft.Controls.Add(this.btnViewAllView);
            this.panelLeft.Controls.Add(this.btnSearchView);
            this.panelLeft.Controls.Add(this.btnAddDoctorView);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(339, 741);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(93, 486);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 85);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "❌ Close Window";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnViewAllView
            // 
            this.btnViewAllView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllView.Location = new System.Drawing.Point(93, 379);
            this.btnViewAllView.Name = "btnViewAllView";
            this.btnViewAllView.Size = new System.Drawing.Size(137, 85);
            this.btnViewAllView.TabIndex = 2;
            this.btnViewAllView.Text = "📋 View All Doctors";
            this.btnViewAllView.UseVisualStyleBackColor = true;
            // 
            // btnSearchView
            // 
            this.btnSearchView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchView.Location = new System.Drawing.Point(93, 272);
            this.btnSearchView.Name = "btnSearchView";
            this.btnSearchView.Size = new System.Drawing.Size(137, 85);
            this.btnSearchView.TabIndex = 1;
            this.btnSearchView.Text = "🔍 Search and Modify";
            this.btnSearchView.UseVisualStyleBackColor = true;
            this.btnSearchView.Click += new System.EventHandler(this.btnSearchView_Click);
            // 
            // btnAddDoctorView
            // 
            this.btnAddDoctorView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDoctorView.Location = new System.Drawing.Point(93, 168);
            this.btnAddDoctorView.Name = "btnAddDoctorView";
            this.btnAddDoctorView.Size = new System.Drawing.Size(137, 85);
            this.btnAddDoctorView.TabIndex = 0;
            this.btnAddDoctorView.Text = "➕ Add New Doctor";
            this.btnAddDoctorView.UseVisualStyleBackColor = true;
            this.btnAddDoctorView.Click += new System.EventHandler(this.btnAddDoctorView_Click);
            // 
            // panelRight
            // 
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(333, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(915, 741);
            this.panelRight.TabIndex = 1;
            this.panelRight.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRight_Paint);
            // 
            // ManageDoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 741);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageDoctorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageDoctorsForm";
            this.Load += new System.EventHandler(this.ManageDoctorsForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnViewAllView;
        private System.Windows.Forms.Button btnSearchView;
        private System.Windows.Forms.Button btnAddDoctorView;
        private System.Windows.Forms.Panel panelRight;
    }
}