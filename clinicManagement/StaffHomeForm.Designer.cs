namespace clinicManagement
{
    partial class StaffHomeForm
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
            this.lblRemainingCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCompletedCount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNewPatientsCount = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = global::clinicManagement.Properties.Resources.Screenshot_2026_07_07_225940;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblRemainingCount);
            this.panel1.Location = new System.Drawing.Point(550, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 281);
            this.panel1.TabIndex = 0;
            // 
            // lblRemainingCount
            // 
            this.lblRemainingCount.AutoSize = true;
            this.lblRemainingCount.BackColor = System.Drawing.Color.Transparent;
            this.lblRemainingCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingCount.ForeColor = System.Drawing.Color.Black;
            this.lblRemainingCount.Location = new System.Drawing.Point(72, 208);
            this.lblRemainingCount.Name = "lblRemainingCount";
            this.lblRemainingCount.Size = new System.Drawing.Size(64, 69);
            this.lblRemainingCount.TabIndex = 1;
            this.lblRemainingCount.Text = "1";
            this.lblRemainingCount.Click += new System.EventHandler(this.lblRemainingCount_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BackgroundImage = global::clinicManagement.Properties.Resources.Screenshot_2026_07_07_2304391;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblCompletedCount);
            this.panel2.Location = new System.Drawing.Point(793, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 281);
            this.panel2.TabIndex = 1;
            // 
            // lblCompletedCount
            // 
            this.lblCompletedCount.AutoSize = true;
            this.lblCompletedCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCompletedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedCount.ForeColor = System.Drawing.Color.Black;
            this.lblCompletedCount.Location = new System.Drawing.Point(59, 208);
            this.lblCompletedCount.Name = "lblCompletedCount";
            this.lblCompletedCount.Size = new System.Drawing.Size(98, 69);
            this.lblCompletedCount.TabIndex = 6;
            this.lblCompletedCount.Text = "12";
            this.lblCompletedCount.Click += new System.EventHandler(this.lblCompletedCount_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BackgroundImage = global::clinicManagement.Properties.Resources.Screenshot_2026_07_07_230920;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblNewPatientsCount);
            this.panel3.Location = new System.Drawing.Point(1058, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 281);
            this.panel3.TabIndex = 1;
            // 
            // lblNewPatientsCount
            // 
            this.lblNewPatientsCount.AutoSize = true;
            this.lblNewPatientsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPatientsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPatientsCount.ForeColor = System.Drawing.Color.Black;
            this.lblNewPatientsCount.Location = new System.Drawing.Point(78, 210);
            this.lblNewPatientsCount.Name = "lblNewPatientsCount";
            this.lblNewPatientsCount.Size = new System.Drawing.Size(64, 69);
            this.lblNewPatientsCount.TabIndex = 6;
            this.lblNewPatientsCount.Text = "5";
            this.lblNewPatientsCount.Click += new System.EventHandler(this.lblNewPatientsCount_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(1124, 463);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 78);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "🔙";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // StaffHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::clinicManagement.Properties.Resources.bg_staff_dashboard_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 723);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "StaffHomeForm";
            this.Text = "StaffHomeForm";
            this.Load += new System.EventHandler(this.StaffHomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblRemainingCount;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblNewPatientsCount;
        private System.Windows.Forms.Label lblCompletedCount;
    }
}