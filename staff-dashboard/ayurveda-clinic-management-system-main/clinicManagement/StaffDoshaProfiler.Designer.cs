namespace clinicManagement
{
    partial class StaffDoshaProfiler
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
            this.lblSelectPatient = new System.Windows.Forms.Label();
            this.btnLoadPatient = new System.Windows.Forms.Button();
            this.grpPatientDetails = new System.Windows.Forms.GroupBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBlood = new System.Windows.Forms.Label();
            this.lblCurrentDosha = new System.Windows.Forms.Label();
            this.lblPatientIDValue = new System.Windows.Forms.Label();
            this.lblPatientIDDValue = new System.Windows.Forms.Label();
            this.lblPatientNameValue = new System.Windows.Forms.Label();
            this.lblPatientAgeValue = new System.Windows.Forms.Label();
            this.lblPatientGenderValue = new System.Windows.Forms.Label();
            this.lblPatientBloodValue = new System.Windows.Forms.Label();
            this.lblCurrentDoshaValue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlQuestions = new System.Windows.Forms.Panel();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.grpPatientDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitle.Location = new System.Drawing.Point(829, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Staff Dosha Profiler";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblSelectPatient
            // 
            this.lblSelectPatient.AutoSize = true;
            this.lblSelectPatient.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPatient.Location = new System.Drawing.Point(359, 102);
            this.lblSelectPatient.Name = "lblSelectPatient";
            this.lblSelectPatient.Size = new System.Drawing.Size(120, 23);
            this.lblSelectPatient.TabIndex = 1;
            this.lblSelectPatient.Text = "Select Patient";
            this.lblSelectPatient.MouseCaptureChanged += new System.EventHandler(this.btnLoadPatient_Click);
            // 
            // btnLoadPatient
            // 
            this.btnLoadPatient.Location = new System.Drawing.Point(485, 128);
            this.btnLoadPatient.Name = "btnLoadPatient";
            this.btnLoadPatient.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPatient.TabIndex = 3;
            this.btnLoadPatient.Text = "Load Patient";
            this.btnLoadPatient.UseVisualStyleBackColor = true;
            this.btnLoadPatient.Click += new System.EventHandler(this.btnLoadPatient_Click_1);
            this.btnLoadPatient.MouseCaptureChanged += new System.EventHandler(this.btnLoadPatient_Click);
            // 
            // grpPatientDetails
            // 
            this.grpPatientDetails.Controls.Add(this.panel1);
            this.grpPatientDetails.Controls.Add(this.lblCurrentDoshaValue);
            this.grpPatientDetails.Controls.Add(this.lblPatientBloodValue);
            this.grpPatientDetails.Controls.Add(this.lblPatientGenderValue);
            this.grpPatientDetails.Controls.Add(this.lblPatientAgeValue);
            this.grpPatientDetails.Controls.Add(this.lblPatientNameValue);
            this.grpPatientDetails.Controls.Add(this.lblPatientIDDValue);
            this.grpPatientDetails.Controls.Add(this.lblPatientIDValue);
            this.grpPatientDetails.Controls.Add(this.lblCurrentDosha);
            this.grpPatientDetails.Controls.Add(this.lblBlood);
            this.grpPatientDetails.Controls.Add(this.lblGender);
            this.grpPatientDetails.Controls.Add(this.lblAge);
            this.grpPatientDetails.Controls.Add(this.lblPatientName);
            this.grpPatientDetails.Controls.Add(this.lblPatientID);
            this.grpPatientDetails.Location = new System.Drawing.Point(358, 173);
            this.grpPatientDetails.Name = "grpPatientDetails";
            this.grpPatientDetails.Size = new System.Drawing.Size(308, 212);
            this.grpPatientDetails.TabIndex = 4;
            this.grpPatientDetails.TabStop = false;
            this.grpPatientDetails.Text = "Patient Details                                                ";
            this.grpPatientDetails.Enter += new System.EventHandler(this.grpPatientDetails_Enter);
            this.grpPatientDetails.MouseCaptureChanged += new System.EventHandler(this.btnLoadPatient_Click);
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(7, 34);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(70, 16);
            this.lblPatientID.TabIndex = 0;
            this.lblPatientID.Text = "Patient ID :";
            this.lblPatientID.Click += new System.EventHandler(this.lblPatientID_Click);
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(7, 61);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(94, 16);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "Patient Name :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(7, 88);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 16);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(7, 114);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(58, 16);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender :";
            // 
            // lblBlood
            // 
            this.lblBlood.AutoSize = true;
            this.lblBlood.Location = new System.Drawing.Point(7, 145);
            this.lblBlood.Name = "lblBlood";
            this.lblBlood.Size = new System.Drawing.Size(89, 16);
            this.lblBlood.TabIndex = 4;
            this.lblBlood.Text = "Blood Group :";
            // 
            // lblCurrentDosha
            // 
            this.lblCurrentDosha.AutoSize = true;
            this.lblCurrentDosha.Location = new System.Drawing.Point(10, 177);
            this.lblCurrentDosha.Name = "lblCurrentDosha";
            this.lblCurrentDosha.Size = new System.Drawing.Size(98, 16);
            this.lblCurrentDosha.TabIndex = 5;
            this.lblCurrentDosha.Text = "Current Dosha :";
            // 
            // lblPatientIDValue
            // 
            this.lblPatientIDValue.AutoSize = true;
            this.lblPatientIDValue.Location = new System.Drawing.Point(83, 34);
            this.lblPatientIDValue.Name = "lblPatientIDValue";
            this.lblPatientIDValue.Size = new System.Drawing.Size(0, 16);
            this.lblPatientIDValue.TabIndex = 6;
            // 
            // lblPatientIDDValue
            // 
            this.lblPatientIDDValue.AutoSize = true;
            this.lblPatientIDDValue.Location = new System.Drawing.Point(124, 34);
            this.lblPatientIDDValue.Name = "lblPatientIDDValue";
            this.lblPatientIDDValue.Size = new System.Drawing.Size(11, 16);
            this.lblPatientIDDValue.TabIndex = 7;
            this.lblPatientIDDValue.Text = "-";
            // 
            // lblPatientNameValue
            // 
            this.lblPatientNameValue.AutoSize = true;
            this.lblPatientNameValue.Location = new System.Drawing.Point(124, 61);
            this.lblPatientNameValue.Name = "lblPatientNameValue";
            this.lblPatientNameValue.Size = new System.Drawing.Size(11, 16);
            this.lblPatientNameValue.TabIndex = 8;
            this.lblPatientNameValue.Text = "-";
            // 
            // lblPatientAgeValue
            // 
            this.lblPatientAgeValue.AutoSize = true;
            this.lblPatientAgeValue.Location = new System.Drawing.Point(124, 88);
            this.lblPatientAgeValue.Name = "lblPatientAgeValue";
            this.lblPatientAgeValue.Size = new System.Drawing.Size(11, 16);
            this.lblPatientAgeValue.TabIndex = 9;
            this.lblPatientAgeValue.Text = "-";
            // 
            // lblPatientGenderValue
            // 
            this.lblPatientGenderValue.AutoSize = true;
            this.lblPatientGenderValue.Location = new System.Drawing.Point(124, 114);
            this.lblPatientGenderValue.Name = "lblPatientGenderValue";
            this.lblPatientGenderValue.Size = new System.Drawing.Size(11, 16);
            this.lblPatientGenderValue.TabIndex = 10;
            this.lblPatientGenderValue.Text = "-";
            // 
            // lblPatientBloodValue
            // 
            this.lblPatientBloodValue.AutoSize = true;
            this.lblPatientBloodValue.Location = new System.Drawing.Point(124, 145);
            this.lblPatientBloodValue.Name = "lblPatientBloodValue";
            this.lblPatientBloodValue.Size = new System.Drawing.Size(11, 16);
            this.lblPatientBloodValue.TabIndex = 11;
            this.lblPatientBloodValue.Text = "-";
            // 
            // lblCurrentDoshaValue
            // 
            this.lblCurrentDoshaValue.AutoSize = true;
            this.lblCurrentDoshaValue.Location = new System.Drawing.Point(124, 177);
            this.lblCurrentDoshaValue.Name = "lblCurrentDoshaValue";
            this.lblCurrentDoshaValue.Size = new System.Drawing.Size(11, 16);
            this.lblCurrentDoshaValue.TabIndex = 12;
            this.lblCurrentDoshaValue.Text = "-";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(10, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 13;
            // 
            // pnlQuestions
            // 
            this.pnlQuestions.AutoScroll = true;
            this.pnlQuestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuestions.Location = new System.Drawing.Point(358, 406);
            this.pnlQuestions.Name = "pnlQuestions";
            this.pnlQuestions.Size = new System.Drawing.Size(308, 151);
            this.pnlQuestions.TabIndex = 5;
            this.pnlQuestions.MouseCaptureChanged += new System.EventHandler(this.btnLoadPatient_Click);
            // 
            // cmbPatient
            // 
            this.cmbPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(358, 128);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(121, 24);
            this.cmbPatient.TabIndex = 6;
            this.cmbPatient.MouseCaptureChanged += new System.EventHandler(this.btnLoadPatient_Click);
            // 
            // StaffDoshaProfiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 676);
            this.Controls.Add(this.cmbPatient);
            this.Controls.Add(this.pnlQuestions);
            this.Controls.Add(this.grpPatientDetails);
            this.Controls.Add(this.btnLoadPatient);
            this.Controls.Add(this.lblSelectPatient);
            this.Controls.Add(this.lblTitle);
            this.Name = "StaffDoshaProfiler";
            this.Text = "StaffDoshaProfiler";
            this.Load += new System.EventHandler(this.StaffDoshaProfiler_Load);
            this.grpPatientDetails.ResumeLayout(false);
            this.grpPatientDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSelectPatient;
        private System.Windows.Forms.Button btnLoadPatient;
        private System.Windows.Forms.GroupBox grpPatientDetails;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblCurrentDosha;
        private System.Windows.Forms.Label lblBlood;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPatientIDValue;
        private System.Windows.Forms.Label lblPatientIDDValue;
        private System.Windows.Forms.Label lblPatientAgeValue;
        private System.Windows.Forms.Label lblPatientNameValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCurrentDoshaValue;
        private System.Windows.Forms.Label lblPatientBloodValue;
        private System.Windows.Forms.Label lblPatientGenderValue;
        private System.Windows.Forms.Panel pnlQuestions;
        private System.Windows.Forms.ComboBox cmbPatient;
    }
}