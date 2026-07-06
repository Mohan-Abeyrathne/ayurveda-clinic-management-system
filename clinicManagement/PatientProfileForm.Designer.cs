namespace clinicManagement
{
    partial class PatientProfileForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpPersonal = new System.Windows.Forms.GroupBox();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblNameStat = new System.Windows.Forms.Label();
            this.lblAgeStat = new System.Windows.Forms.Label();
            this.lblGenderStat = new System.Windows.Forms.Label();
            this.lblBloodStat = new System.Windows.Forms.Label();
            this.lblPhoneStat = new System.Windows.Forms.Label();
            this.lblAddressStat = new System.Windows.Forms.Label();
            this.lblAgeValue = new System.Windows.Forms.Label();
            this.lblGenderValue = new System.Windows.Forms.Label();
            this.lblBloodValue = new System.Windows.Forms.Label();
            this.lblPhoneValue = new System.Windows.Forms.Label();
            this.lblAddressValue = new System.Windows.Forms.Label();
            this.grpDosha = new System.Windows.Forms.GroupBox();
            this.lblAssessmentDateValue = new System.Windows.Forms.Label();
            this.lblAssessmentStat = new System.Windows.Forms.Label();
            this.lblBodyStat = new System.Windows.Forms.Label();
            this.lblDoshaValue = new System.Windows.Forms.Label();
            this.grpHistory = new System.Windows.Forms.GroupBox();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.grpPrescriptions = new System.Windows.Forms.GroupBox();
            this.dgvPrescriptions = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTherapy = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpPersonal.SuspendLayout();
            this.grpDosha.SuspendLayout();
            this.grpHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.grpPrescriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTherapy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitle.Location = new System.Drawing.Point(501, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(337, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Patient Profile and History";
            // 
            // grpPersonal
            // 
            this.grpPersonal.BackColor = System.Drawing.SystemColors.Control;
            this.grpPersonal.Controls.Add(this.lblAddressValue);
            this.grpPersonal.Controls.Add(this.lblPhoneValue);
            this.grpPersonal.Controls.Add(this.lblBloodValue);
            this.grpPersonal.Controls.Add(this.lblGenderValue);
            this.grpPersonal.Controls.Add(this.lblAgeValue);
            this.grpPersonal.Controls.Add(this.lblAddressStat);
            this.grpPersonal.Controls.Add(this.lblPhoneStat);
            this.grpPersonal.Controls.Add(this.lblBloodStat);
            this.grpPersonal.Controls.Add(this.lblGenderStat);
            this.grpPersonal.Controls.Add(this.lblAgeStat);
            this.grpPersonal.Controls.Add(this.lblNameStat);
            this.grpPersonal.Controls.Add(this.lblNameValue);
            this.grpPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpPersonal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonal.Location = new System.Drawing.Point(29, 106);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Size = new System.Drawing.Size(593, 249);
            this.grpPersonal.TabIndex = 1;
            this.grpPersonal.TabStop = false;
            this.grpPersonal.Text = "Personal Information";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Location = new System.Drawing.Point(171, 42);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(20, 27);
            this.lblNameValue.TabIndex = 0;
            this.lblNameValue.Text = "-";
            // 
            // lblNameStat
            // 
            this.lblNameStat.AutoSize = true;
            this.lblNameStat.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameStat.Location = new System.Drawing.Point(56, 47);
            this.lblNameStat.Name = "lblNameStat";
            this.lblNameStat.Size = new System.Drawing.Size(105, 22);
            this.lblNameStat.TabIndex = 1;
            this.lblNameStat.Text = "Patient Name:";
            // 
            // lblAgeStat
            // 
            this.lblAgeStat.AutoSize = true;
            this.lblAgeStat.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeStat.Location = new System.Drawing.Point(56, 79);
            this.lblAgeStat.Name = "lblAgeStat";
            this.lblAgeStat.Size = new System.Drawing.Size(42, 22);
            this.lblAgeStat.TabIndex = 2;
            this.lblAgeStat.Text = "Age:";
            // 
            // lblGenderStat
            // 
            this.lblGenderStat.AutoSize = true;
            this.lblGenderStat.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderStat.Location = new System.Drawing.Point(56, 112);
            this.lblGenderStat.Name = "lblGenderStat";
            this.lblGenderStat.Size = new System.Drawing.Size(66, 22);
            this.lblGenderStat.TabIndex = 3;
            this.lblGenderStat.Text = "Gender:";
            // 
            // lblBloodStat
            // 
            this.lblBloodStat.AutoSize = true;
            this.lblBloodStat.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodStat.Location = new System.Drawing.Point(56, 144);
            this.lblBloodStat.Name = "lblBloodStat";
            this.lblBloodStat.Size = new System.Drawing.Size(104, 22);
            this.lblBloodStat.TabIndex = 4;
            this.lblBloodStat.Text = "Blood Group:";
            // 
            // lblPhoneStat
            // 
            this.lblPhoneStat.AutoSize = true;
            this.lblPhoneStat.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneStat.Location = new System.Drawing.Point(56, 177);
            this.lblPhoneStat.Name = "lblPhoneStat";
            this.lblPhoneStat.Size = new System.Drawing.Size(59, 22);
            this.lblPhoneStat.TabIndex = 5;
            this.lblPhoneStat.Text = "Phone:";
            // 
            // lblAddressStat
            // 
            this.lblAddressStat.AutoSize = true;
            this.lblAddressStat.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressStat.Location = new System.Drawing.Point(55, 209);
            this.lblAddressStat.Name = "lblAddressStat";
            this.lblAddressStat.Size = new System.Drawing.Size(73, 22);
            this.lblAddressStat.TabIndex = 2;
            this.lblAddressStat.Text = "Address:";
            // 
            // lblAgeValue
            // 
            this.lblAgeValue.AutoSize = true;
            this.lblAgeValue.Location = new System.Drawing.Point(171, 74);
            this.lblAgeValue.Name = "lblAgeValue";
            this.lblAgeValue.Size = new System.Drawing.Size(20, 27);
            this.lblAgeValue.TabIndex = 6;
            this.lblAgeValue.Text = "-";
            // 
            // lblGenderValue
            // 
            this.lblGenderValue.AutoSize = true;
            this.lblGenderValue.Location = new System.Drawing.Point(171, 107);
            this.lblGenderValue.Name = "lblGenderValue";
            this.lblGenderValue.Size = new System.Drawing.Size(20, 27);
            this.lblGenderValue.TabIndex = 2;
            this.lblGenderValue.Text = "-";
            // 
            // lblBloodValue
            // 
            this.lblBloodValue.AutoSize = true;
            this.lblBloodValue.Location = new System.Drawing.Point(171, 139);
            this.lblBloodValue.Name = "lblBloodValue";
            this.lblBloodValue.Size = new System.Drawing.Size(20, 27);
            this.lblBloodValue.TabIndex = 2;
            this.lblBloodValue.Text = "-";
            // 
            // lblPhoneValue
            // 
            this.lblPhoneValue.AutoSize = true;
            this.lblPhoneValue.Location = new System.Drawing.Point(171, 172);
            this.lblPhoneValue.Name = "lblPhoneValue";
            this.lblPhoneValue.Size = new System.Drawing.Size(20, 27);
            this.lblPhoneValue.TabIndex = 2;
            this.lblPhoneValue.Text = "-";
            // 
            // lblAddressValue
            // 
            this.lblAddressValue.AutoSize = true;
            this.lblAddressValue.Location = new System.Drawing.Point(171, 204);
            this.lblAddressValue.Name = "lblAddressValue";
            this.lblAddressValue.Size = new System.Drawing.Size(20, 27);
            this.lblAddressValue.TabIndex = 2;
            this.lblAddressValue.Text = "-";
            // 
            // grpDosha
            // 
            this.grpDosha.Controls.Add(this.lblAssessmentDateValue);
            this.grpDosha.Controls.Add(this.lblAssessmentStat);
            this.grpDosha.Controls.Add(this.lblBodyStat);
            this.grpDosha.Controls.Add(this.lblDoshaValue);
            this.grpDosha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpDosha.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDosha.Location = new System.Drawing.Point(666, 106);
            this.grpDosha.Name = "grpDosha";
            this.grpDosha.Size = new System.Drawing.Size(593, 142);
            this.grpDosha.TabIndex = 7;
            this.grpDosha.TabStop = false;
            this.grpDosha.Text = "Dosha Information";
            // 
            // lblAssessmentDateValue
            // 
            this.lblAssessmentDateValue.AutoSize = true;
            this.lblAssessmentDateValue.Location = new System.Drawing.Point(193, 84);
            this.lblAssessmentDateValue.Name = "lblAssessmentDateValue";
            this.lblAssessmentDateValue.Size = new System.Drawing.Size(20, 27);
            this.lblAssessmentDateValue.TabIndex = 6;
            this.lblAssessmentDateValue.Text = "-";
            this.lblAssessmentDateValue.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblAssessmentStat
            // 
            this.lblAssessmentStat.AutoSize = true;
            this.lblAssessmentStat.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssessmentStat.Location = new System.Drawing.Point(58, 89);
            this.lblAssessmentStat.Name = "lblAssessmentStat";
            this.lblAssessmentStat.Size = new System.Drawing.Size(134, 22);
            this.lblAssessmentStat.TabIndex = 2;
            this.lblAssessmentStat.Text = "Assessment Date:";
            // 
            // lblBodyStat
            // 
            this.lblBodyStat.AutoSize = true;
            this.lblBodyStat.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodyStat.Location = new System.Drawing.Point(58, 57);
            this.lblBodyStat.Name = "lblBodyStat";
            this.lblBodyStat.Size = new System.Drawing.Size(89, 22);
            this.lblBodyStat.TabIndex = 1;
            this.lblBodyStat.Text = "Body Type:";
            // 
            // lblDoshaValue
            // 
            this.lblDoshaValue.AutoSize = true;
            this.lblDoshaValue.Location = new System.Drawing.Point(193, 52);
            this.lblDoshaValue.Name = "lblDoshaValue";
            this.lblDoshaValue.Size = new System.Drawing.Size(20, 27);
            this.lblDoshaValue.TabIndex = 0;
            this.lblDoshaValue.Text = "-";
            // 
            // grpHistory
            // 
            this.grpHistory.Controls.Add(this.dgvHistory);
            this.grpHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpHistory.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHistory.Location = new System.Drawing.Point(29, 371);
            this.grpHistory.Name = "grpHistory";
            this.grpHistory.Size = new System.Drawing.Size(1230, 194);
            this.grpHistory.TabIndex = 8;
            this.grpHistory.TabStop = false;
            this.grpHistory.Text = "Previous Diagnoses";
            // 
            // dgvHistory
            // 
            this.dgvHistory.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(62, 51);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.Size = new System.Drawing.Size(1136, 113);
            this.dgvHistory.TabIndex = 0;
            // 
            // grpPrescriptions
            // 
            this.grpPrescriptions.Controls.Add(this.dgvPrescriptions);
            this.grpPrescriptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpPrescriptions.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPrescriptions.Location = new System.Drawing.Point(29, 581);
            this.grpPrescriptions.Name = "grpPrescriptions";
            this.grpPrescriptions.Size = new System.Drawing.Size(1230, 199);
            this.grpPrescriptions.TabIndex = 9;
            this.grpPrescriptions.TabStop = false;
            this.grpPrescriptions.Text = "Previous Prescriptions";
            this.grpPrescriptions.Enter += new System.EventHandler(this.grpPrescriptions_Enter);
            // 
            // dgvPrescriptions
            // 
            this.dgvPrescriptions.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescriptions.Location = new System.Drawing.Point(62, 51);
            this.dgvPrescriptions.Name = "dgvPrescriptions";
            this.dgvPrescriptions.RowHeadersWidth = 51;
            this.dgvPrescriptions.RowTemplate.Height = 24;
            this.dgvPrescriptions.Size = new System.Drawing.Size(1136, 113);
            this.dgvPrescriptions.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTherapy);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 796);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1230, 199);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Previous Therapy Sessions";
            // 
            // dgvTherapy
            // 
            this.dgvTherapy.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTherapy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTherapy.Location = new System.Drawing.Point(62, 51);
            this.dgvTherapy.Name = "dgvTherapy";
            this.dgvTherapy.RowHeadersWidth = 51;
            this.dgvTherapy.RowTemplate.Height = 24;
            this.dgvTherapy.Size = new System.Drawing.Size(1136, 113);
            this.dgvTherapy.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Honeydew;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(394, 1001);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(263, 30);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Generate Clinical Summary";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Honeydew;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(696, 1001);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(263, 30);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PatientProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 1055);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPrescriptions);
            this.Controls.Add(this.grpHistory);
            this.Controls.Add(this.grpDosha);
            this.Controls.Add(this.grpPersonal);
            this.Controls.Add(this.lblTitle);
            this.Name = "PatientProfileForm";
            this.Text = "Patient Profile";
            this.Load += new System.EventHandler(this.PatientProfileForm_Load);
            this.grpPersonal.ResumeLayout(false);
            this.grpPersonal.PerformLayout();
            this.grpDosha.ResumeLayout(false);
            this.grpDosha.PerformLayout();
            this.grpHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.grpPrescriptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTherapy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpPersonal;
        private System.Windows.Forms.Label lblNameStat;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblGenderValue;
        private System.Windows.Forms.Label lblAgeValue;
        private System.Windows.Forms.Label lblAddressStat;
        private System.Windows.Forms.Label lblPhoneStat;
        private System.Windows.Forms.Label lblBloodStat;
        private System.Windows.Forms.Label lblGenderStat;
        private System.Windows.Forms.Label lblAgeStat;
        private System.Windows.Forms.Label lblAddressValue;
        private System.Windows.Forms.Label lblPhoneValue;
        private System.Windows.Forms.Label lblBloodValue;
        private System.Windows.Forms.GroupBox grpDosha;
        private System.Windows.Forms.Label lblAssessmentDateValue;
        private System.Windows.Forms.Label lblAssessmentStat;
        private System.Windows.Forms.Label lblBodyStat;
        private System.Windows.Forms.Label lblDoshaValue;
        private System.Windows.Forms.GroupBox grpHistory;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.GroupBox grpPrescriptions;
        private System.Windows.Forms.DataGridView dgvPrescriptions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTherapy;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
    }
}