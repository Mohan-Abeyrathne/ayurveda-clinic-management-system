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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPatients = new System.Windows.Forms.ComboBox();
            this.btnViewTherapies = new System.Windows.Forms.Button();
            this.lblDoshaType = new System.Windows.Forms.Label();
            this.dgvTherapies = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTherapies)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(171, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Patient";
            // 
            // cmbPatients
            // 
            this.cmbPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbPatients.FormattingEnabled = true;
            this.cmbPatients.Location = new System.Drawing.Point(407, 118);
            this.cmbPatients.Name = "cmbPatients";
            this.cmbPatients.Size = new System.Drawing.Size(121, 30);
            this.cmbPatients.TabIndex = 1;
            // 
            // btnViewTherapies
            // 
            this.btnViewTherapies.BackColor = System.Drawing.SystemColors.Info;
            this.btnViewTherapies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTherapies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnViewTherapies.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnViewTherapies.Location = new System.Drawing.Point(651, 114);
            this.btnViewTherapies.Name = "btnViewTherapies";
            this.btnViewTherapies.Size = new System.Drawing.Size(154, 38);
            this.btnViewTherapies.TabIndex = 2;
            this.btnViewTherapies.Text = "View Therapies";
            this.btnViewTherapies.UseVisualStyleBackColor = false;
            // 
            // lblDoshaType
            // 
            this.lblDoshaType.AutoSize = true;
            this.lblDoshaType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblDoshaType.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDoshaType.Location = new System.Drawing.Point(304, 180);
            this.lblDoshaType.Name = "lblDoshaType";
            this.lblDoshaType.Size = new System.Drawing.Size(120, 21);
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
            this.dgvTherapies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTherapies.EnableHeadersVisualStyles = false;
            this.dgvTherapies.GridColor = System.Drawing.Color.LightGreen;
            this.dgvTherapies.Location = new System.Drawing.Point(224, 238);
            this.dgvTherapies.Name = "dgvTherapies";
            this.dgvTherapies.RowHeadersWidth = 62;
            this.dgvTherapies.RowTemplate.Height = 28;
            this.dgvTherapies.Size = new System.Drawing.Size(514, 246);
            this.dgvTherapies.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Therapy";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Description";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Duration";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(264, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dosha Matched Therapy Viewer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TherapyViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTherapies);
            this.Controls.Add(this.lblDoshaType);
            this.Controls.Add(this.btnViewTherapies);
            this.Controls.Add(this.cmbPatients);
            this.Controls.Add(this.label1);
            this.Name = "TherapyViewer";
            this.Text = "TherapyViewer";
            this.Load += new System.EventHandler(this.TherapyViewer_Load_1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label2;
    }
}