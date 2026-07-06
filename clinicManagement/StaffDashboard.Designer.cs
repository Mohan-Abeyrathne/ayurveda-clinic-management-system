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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMainDashboard = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPatientManagement = new System.Windows.Forms.Button();
            this.btnDoshaProfiler = new System.Windows.Forms.Button();
            this.btnHerbalStock = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(945, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Staff Dashboard!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnHerbalStock);
            this.panel1.Controls.Add(this.btnMainDashboard);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnPatientManagement);
            this.panel1.Controls.Add(this.btnDoshaProfiler);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 721);
            this.panel1.TabIndex = 1;
            // 
            // btnMainDashboard
            // 
            this.btnMainDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainDashboard.Location = new System.Drawing.Point(62, 197);
            this.btnMainDashboard.Name = "btnMainDashboard";
            this.btnMainDashboard.Size = new System.Drawing.Size(198, 63);
            this.btnMainDashboard.TabIndex = 0;
            this.btnMainDashboard.Text = "Main Dashboard";
            this.btnMainDashboard.UseVisualStyleBackColor = true;
            this.btnMainDashboard.Click += new System.EventHandler(this.btnMainDashboard_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(62, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "Book Appointment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPatientManagement
            // 
            this.btnPatientManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientManagement.Location = new System.Drawing.Point(62, 374);
            this.btnPatientManagement.Name = "btnPatientManagement";
            this.btnPatientManagement.Size = new System.Drawing.Size(198, 63);
            this.btnPatientManagement.TabIndex = 2;
            this.btnPatientManagement.Text = "Patient Management";
            this.btnPatientManagement.UseVisualStyleBackColor = true;
            this.btnPatientManagement.Click += new System.EventHandler(this.btnPatientManagement_Click);
            // 
            // btnDoshaProfiler
            // 
            this.btnDoshaProfiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoshaProfiler.Location = new System.Drawing.Point(62, 469);
            this.btnDoshaProfiler.Name = "btnDoshaProfiler";
            this.btnDoshaProfiler.Size = new System.Drawing.Size(198, 63);
            this.btnDoshaProfiler.TabIndex = 3;
            this.btnDoshaProfiler.Text = "Digital Dosha Profiler";
            this.btnDoshaProfiler.UseVisualStyleBackColor = true;
            this.btnDoshaProfiler.Click += new System.EventHandler(this.btnDoshaProfiler_Click);
            // 
            // btnHerbalStock
            // 
            this.btnHerbalStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHerbalStock.Location = new System.Drawing.Point(62, 563);
            this.btnHerbalStock.Name = "btnHerbalStock";
            this.btnHerbalStock.Size = new System.Drawing.Size(198, 63);
            this.btnHerbalStock.TabIndex = 4;
            this.btnHerbalStock.Text = "Herbal Stock";
            this.btnHerbalStock.UseVisualStyleBackColor = true;
            this.btnHerbalStock.Click += new System.EventHandler(this.btnHerbalStock_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(28, 668);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(92, 35);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "↩️Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(80, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 136);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // StaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 712);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "StaffDashboard";
            this.Text = "StaffDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffDashboard_FormClosed);
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
    }
}