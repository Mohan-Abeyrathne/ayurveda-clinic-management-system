namespace clinicManagement
{
    partial class PatientFileViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientFileViewer));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(416, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient File Viewer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(457, 258);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(262, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search patient";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Honeydew;
            this.btnSearch.Location = new System.Drawing.Point(741, 252);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.btnSearch_MouseEnter);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatients.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.GridColor = System.Drawing.Color.DarkGreen;
            this.dgvPatients.Location = new System.Drawing.Point(35, 311);
            this.dgvPatients.MultiSelect = false;
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.RowTemplate.Height = 24;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(1212, 322);
            this.dgvPatients.TabIndex = 3;
            this.dgvPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellContentClick);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnViewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProfile.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.ForeColor = System.Drawing.Color.Honeydew;
            this.btnViewProfile.Location = new System.Drawing.Point(333, 690);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(332, 39);
            this.btnViewProfile.TabIndex = 4;
            this.btnViewProfile.Text = "View Patient Profile";
            this.btnViewProfile.UseVisualStyleBackColor = false;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            this.btnViewProfile.MouseEnter += new System.EventHandler(this.btnViewProfile_MouseEnter);
            this.btnViewProfile.MouseLeave += new System.EventHandler(this.btnViewProfile_MouseLeave);
            // 
            // btnClose1
            // 
            this.btnClose1.BackColor = System.Drawing.Color.Transparent;
            this.btnClose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose1.ForeColor = System.Drawing.Color.Honeydew;
            this.btnClose1.Location = new System.Drawing.Point(685, 690);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(332, 39);
            this.btnClose1.TabIndex = 5;
            this.btnClose1.Text = "Close";
            this.btnClose1.UseVisualStyleBackColor = false;
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            this.btnClose1.MouseEnter += new System.EventHandler(this.btnClose1_MouseEnter);
            this.btnClose1.MouseLeave += new System.EventHandler(this.btnClose1_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(970, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "* Ayurveda Clinic Management System *";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PatientFileViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1286, 782);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose1);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.dgvPatients);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "PatientFileViewer";
            this.Text = "Patient File Viewer";
            this.Load += new System.EventHandler(this.PatientFileViewer_Load);
            this.Resize += new System.EventHandler(this.PatientFileViewer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnClose1;
        private System.Windows.Forms.Label label3;
    }
}