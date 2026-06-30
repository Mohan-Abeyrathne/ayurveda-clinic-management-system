namespace clinicManagement
{
    partial class UC_ViewAllDoctors
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
            this.dgvAllDoctorsRegistry = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDoctorsRegistry)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medical Staff Registry Overview";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvAllDoctorsRegistry
            // 
            this.dgvAllDoctorsRegistry.AllowUserToAddRows = false;
            this.dgvAllDoctorsRegistry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllDoctorsRegistry.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvAllDoctorsRegistry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllDoctorsRegistry.Location = new System.Drawing.Point(23, 60);
            this.dgvAllDoctorsRegistry.Name = "dgvAllDoctorsRegistry";
            this.dgvAllDoctorsRegistry.ReadOnly = true;
            this.dgvAllDoctorsRegistry.RowHeadersWidth = 51;
            this.dgvAllDoctorsRegistry.RowTemplate.Height = 24;
            this.dgvAllDoctorsRegistry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllDoctorsRegistry.Size = new System.Drawing.Size(875, 610);
            this.dgvAllDoctorsRegistry.TabIndex = 1;
            this.dgvAllDoctorsRegistry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllDoctorsRegistry_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 683);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "* Ayurveda Clinic Management System *";
            // 
            // UC_ViewAllDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAllDoctorsRegistry);
            this.Controls.Add(this.label1);
            this.Name = "UC_ViewAllDoctors";
            this.Size = new System.Drawing.Size(922, 735);
            this.Load += new System.EventHandler(this.UC_ViewAllDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDoctorsRegistry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAllDoctorsRegistry;
        private System.Windows.Forms.Label label2;
    }
}
