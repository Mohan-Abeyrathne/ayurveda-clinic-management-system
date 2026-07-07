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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
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
            this.lblRemainingCount.Location = new System.Drawing.Point(65, 208);
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
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(793, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 281);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "12";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BackgroundImage = global::clinicManagement.Properties.Resources.Screenshot_2026_07_07_230920;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(1058, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 281);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(76, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 69);
            this.label2.TabIndex = 4;
            this.label2.Text = "5";
            // 
            // StaffHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::clinicManagement.Properties.Resources.bg_staff_dashboard_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 723);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}