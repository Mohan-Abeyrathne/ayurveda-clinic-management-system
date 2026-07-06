namespace clinicManagement
{
    partial class UC_ViewAllStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAllStaffRegistry = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStaffRegistry)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Active Support and Staff Registry Overview";
            // 
            // dgvAllStaffRegistry
            // 
            this.dgvAllStaffRegistry.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllStaffRegistry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllStaffRegistry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllStaffRegistry.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvAllStaffRegistry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllStaffRegistry.Location = new System.Drawing.Point(44, 90);
            this.dgvAllStaffRegistry.Name = "dgvAllStaffRegistry";
            this.dgvAllStaffRegistry.ReadOnly = true;
            this.dgvAllStaffRegistry.RowHeadersWidth = 51;
            this.dgvAllStaffRegistry.RowTemplate.Height = 24;
            this.dgvAllStaffRegistry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllStaffRegistry.Size = new System.Drawing.Size(820, 519);
            this.dgvAllStaffRegistry.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 678);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(438, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "* Ayurveda Clinic Management System *";
            // 
            // UC_ViewAllStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvAllStaffRegistry);
            this.Controls.Add(this.label1);
            this.Name = "UC_ViewAllStaff";
            this.Size = new System.Drawing.Size(911, 735);
            this.Load += new System.EventHandler(this.UC_ViewAllStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStaffRegistry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAllStaffRegistry;
        private System.Windows.Forms.Label label5;
    }
}
