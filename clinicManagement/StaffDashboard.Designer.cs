namespace clinicManagement
{
    partial class StaffDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnHerbalStock = new System.Windows.Forms.Button();
            this.btnMainDashboard = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPatientManagement = new System.Windows.Forms.Button();
            this.btnDoshaProfiler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(916, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Staff Dashboard!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnHerbalStock);
            this.panel1.Controls.Add(this.btnMainDashboard);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnPatientManagement);
            this.panel1.Controls.Add(this.btnDoshaProfiler);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 723);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::clinicManagement.Properties.Resources.admin_bg_3;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(44, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 182);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(98, 656);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(109, 35);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "↩️Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnHerbalStock
            // 
            this.btnHerbalStock.BackColor = System.Drawing.Color.Transparent;
            this.btnHerbalStock.FlatAppearance.BorderSize = 0;
            this.btnHerbalStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHerbalStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHerbalStock.Location = new System.Drawing.Point(0, 574);
            this.btnHerbalStock.Name = "btnHerbalStock";
            this.btnHerbalStock.Size = new System.Drawing.Size(310, 63);
            this.btnHerbalStock.TabIndex = 4;
            this.btnHerbalStock.Text = "Herbal Stock";
            this.btnHerbalStock.UseVisualStyleBackColor = false;
            this.btnHerbalStock.Click += new System.EventHandler(this.btnHerbalStock_Click);
            // 
            // btnMainDashboard
            // 
            this.btnMainDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnMainDashboard.FlatAppearance.BorderSize = 0;
            this.btnMainDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainDashboard.Location = new System.Drawing.Point(1, 225);
            this.btnMainDashboard.Name = "btnMainDashboard";
            this.btnMainDashboard.Size = new System.Drawing.Size(309, 63);
            this.btnMainDashboard.TabIndex = 0;
            this.btnMainDashboard.Text = "Main Dashboard";
            this.btnMainDashboard.UseVisualStyleBackColor = false;
            this.btnMainDashboard.Click += new System.EventHandler(this.btnMainDashboard_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(-3, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(310, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "Book Appointment";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPatientManagement
            // 
            this.btnPatientManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnPatientManagement.FlatAppearance.BorderSize = 0;
            this.btnPatientManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientManagement.Location = new System.Drawing.Point(-3, 392);
            this.btnPatientManagement.Name = "btnPatientManagement";
            this.btnPatientManagement.Size = new System.Drawing.Size(310, 63);
            this.btnPatientManagement.TabIndex = 2;
            this.btnPatientManagement.Text = "Patient Management";
            this.btnPatientManagement.UseVisualStyleBackColor = false;
            this.btnPatientManagement.Click += new System.EventHandler(this.btnPatientManagement_Click);
            // 
            // btnDoshaProfiler
            // 
            this.btnDoshaProfiler.BackColor = System.Drawing.Color.Transparent;
            this.btnDoshaProfiler.FlatAppearance.BorderSize = 0;
            this.btnDoshaProfiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoshaProfiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoshaProfiler.Location = new System.Drawing.Point(-3, 482);
            this.btnDoshaProfiler.Name = "btnDoshaProfiler";
            this.btnDoshaProfiler.Size = new System.Drawing.Size(310, 63);
            this.btnDoshaProfiler.TabIndex = 3;
            this.btnDoshaProfiler.Text = "Digital Dosha Profiler";
            this.btnDoshaProfiler.UseVisualStyleBackColor = false;
            this.btnDoshaProfiler.Click += new System.EventHandler(this.btnDoshaProfiler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(605, 655);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "* Ayurveda Clinic Management System *";
            // 
            // StaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 723);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "StaffDashboard";
            this.Text = "StaffDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffDashboard_FormClosed);
            this.Load += new System.EventHandler(this.StaffDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnHerbalStock;
        private System.Windows.Forms.Button btnDoshaProfiler;
        private System.Windows.Forms.Button btnPatientManagement;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMainDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}