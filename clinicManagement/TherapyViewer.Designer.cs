namespace clinicManagement
{
    partial class TherapyViewer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TherapyViewer));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPatients = new System.Windows.Forms.ComboBox();
            this.btnViewTherapies = new System.Windows.Forms.Button();
            this.lblDoshaType = new System.Windows.Forms.Label();
            this.dgvTherapies = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTherapies)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(376, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Patient";
            // 
            // cmbPatients
            // 
            this.cmbPatients.BackColor = System.Drawing.Color.Honeydew;
            this.cmbPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbPatients.FormattingEnabled = true;
            this.cmbPatients.Location = new System.Drawing.Point(518, 492);
            this.cmbPatients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPatients.Name = "cmbPatients";
            this.cmbPatients.Size = new System.Drawing.Size(326, 30);
            this.cmbPatients.TabIndex = 1;
            // 
            // btnViewTherapies
            // 
            this.btnViewTherapies.BackColor = System.Drawing.Color.Transparent;
            this.btnViewTherapies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTherapies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnViewTherapies.ForeColor = System.Drawing.Color.Honeydew;
            this.btnViewTherapies.Location = new System.Drawing.Point(900, 482);
            this.btnViewTherapies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewTherapies.Name = "btnViewTherapies";
            this.btnViewTherapies.Size = new System.Drawing.Size(204, 52);
            this.btnViewTherapies.TabIndex = 2;
            this.btnViewTherapies.Text = "View Therapies";
            this.btnViewTherapies.UseVisualStyleBackColor = false;
            this.btnViewTherapies.Click += new System.EventHandler(this.btnViewTherapies_Click);
            this.btnViewTherapies.MouseEnter += new System.EventHandler(this.btnViewTherapies_MouseEnter);
            this.btnViewTherapies.MouseLeave += new System.EventHandler(this.btnViewTherapies_MouseLeave);
            // 
            // lblDoshaType
            // 
            this.lblDoshaType.AutoSize = true;
            this.lblDoshaType.BackColor = System.Drawing.Color.Transparent;
            this.lblDoshaType.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoshaType.ForeColor = System.Drawing.Color.Honeydew;
            this.lblDoshaType.Location = new System.Drawing.Point(513, 660);
            this.lblDoshaType.Name = "lblDoshaType";
            this.lblDoshaType.Size = new System.Drawing.Size(119, 25);
            this.lblDoshaType.TabIndex = 3;
            this.lblDoshaType.Text = "Dosha Type:";
            // 
            // dgvTherapies
            // 
            this.dgvTherapies.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTherapies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTherapies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTherapies.EnableHeadersVisualStyles = false;
            this.dgvTherapies.GridColor = System.Drawing.Color.LightGreen;
            this.dgvTherapies.Location = new System.Drawing.Point(451, 716);
            this.dgvTherapies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTherapies.Name = "dgvTherapies";
            this.dgvTherapies.RowHeadersWidth = 62;
            this.dgvTherapies.RowTemplate.Height = 28;
            this.dgvTherapies.Size = new System.Drawing.Size(582, 416);
            this.dgvTherapies.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(328, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(876, 59);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dosha Matched Therapy Viewer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(1086, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "* Ayurveda Clinic Management System *";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TherapyViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1441, 1050);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTherapies);
            this.Controls.Add(this.lblDoshaType);
            this.Controls.Add(this.btnViewTherapies);
            this.Controls.Add(this.cmbPatients);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TherapyViewer";
            this.Text = "TherapyViewer";
            this.Load += new System.EventHandler(this.TherapyViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTherapies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPatients;
        private System.Windows.Forms.Button btnViewTherapies;
        private System.Windows.Forms.Label lblDoshaType;
        private System.Windows.Forms.DataGridView dgvTherapies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}