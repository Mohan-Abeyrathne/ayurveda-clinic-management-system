namespace clinicManagement
{
    partial class DoctorDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPatientFiles = new System.Windows.Forms.Button();
            this.btnDiagnosis = new System.Windows.Forms.Button();
            this.btnPrescription = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(252, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(809, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Doctor Dashboard!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPatientFiles
            // 
            this.btnPatientFiles.BackColor = System.Drawing.Color.Transparent;
            this.btnPatientFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientFiles.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientFiles.ForeColor = System.Drawing.Color.Honeydew;
            this.btnPatientFiles.Location = new System.Drawing.Point(115, 241);
            this.btnPatientFiles.Name = "btnPatientFiles";
            this.btnPatientFiles.Size = new System.Drawing.Size(243, 52);
            this.btnPatientFiles.TabIndex = 1;
            this.btnPatientFiles.Text = "View Patient Files";
            this.btnPatientFiles.UseVisualStyleBackColor = false;
            this.btnPatientFiles.Click += new System.EventHandler(this.btnPatientFiles_Click);
            // 
            // btnDiagnosis
            // 
            this.btnDiagnosis.BackColor = System.Drawing.Color.Transparent;
            this.btnDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnosis.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnosis.ForeColor = System.Drawing.Color.Honeydew;
            this.btnDiagnosis.Location = new System.Drawing.Point(383, 241);
            this.btnDiagnosis.Name = "btnDiagnosis";
            this.btnDiagnosis.Size = new System.Drawing.Size(243, 52);
            this.btnDiagnosis.TabIndex = 2;
            this.btnDiagnosis.Text = "Diagnosis";
            this.btnDiagnosis.UseVisualStyleBackColor = false;
            this.btnDiagnosis.Click += new System.EventHandler(this.btnDiagnosis_Click);
            // 
            // btnPrescription
            // 
            this.btnPrescription.BackColor = System.Drawing.Color.Transparent;
            this.btnPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrescription.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrescription.ForeColor = System.Drawing.Color.Honeydew;
            this.btnPrescription.Location = new System.Drawing.Point(652, 241);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.Size = new System.Drawing.Size(243, 52);
            this.btnPrescription.TabIndex = 3;
            this.btnPrescription.Text = "Prescriptions";
            this.btnPrescription.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Honeydew;
            this.btnLogOut.Location = new System.Drawing.Point(1146, 23);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(112, 34);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Honeydew;
            this.button1.Location = new System.Drawing.Point(919, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Therapy Shedules Management";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DoctorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 719);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnPrescription);
            this.Controls.Add(this.btnDiagnosis);
            this.Controls.Add(this.btnPatientFiles);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "DoctorDashboard";
            this.Text = "Doctor Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorDashboard_FormClosed);
            this.Load += new System.EventHandler(this.DoctorDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPatientFiles;
        private System.Windows.Forms.Button btnDiagnosis;
        private System.Windows.Forms.Button btnPrescription;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button button1;
    }
}