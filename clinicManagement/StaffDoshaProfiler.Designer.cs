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
            this.lblCurrentDoshaValue = new System.Windows.Forms.Label();
            this.lblPatientBloodValue = new System.Windows.Forms.Label();
            this.lblPatientGenderValue = new System.Windows.Forms.Label();
            this.lblPatientAgeValue = new System.Windows.Forms.Label();
            this.lblPatientNameValue = new System.Windows.Forms.Label();
            this.lblPatientIDDValue = new System.Windows.Forms.Label();
            this.lblPatientIDValue = new System.Windows.Forms.Label();
            this.lblCurrentDosha = new System.Windows.Forms.Label();
            this.lblBlood = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.grpQuestions = new System.Windows.Forms.GroupBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.rbOption3 = new System.Windows.Forms.RadioButton();
            this.rbOption2 = new System.Windows.Forms.RadioButton();
            this.rbOption1 = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblQuestionNo = new System.Windows.Forms.Label();
            this.grpPatientDetails.SuspendLayout();
            this.grpQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitle.Location = new System.Drawing.Point(502, 9);
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
            this.lblSelectPatient.Location = new System.Drawing.Point(365, 133);
            this.lblSelectPatient.Name = "lblSelectPatient";
            this.lblSelectPatient.Size = new System.Drawing.Size(120, 23);
            this.lblSelectPatient.TabIndex = 1;
            this.lblSelectPatient.Text = "Select Patient";
            this.lblSelectPatient.MouseCaptureChanged += new System.EventHandler(this.btnLoadPatient_Click);
            // 
            // btnLoadPatient
            // 
            this.btnLoadPatient.Location = new System.Drawing.Point(653, 133);
            this.btnLoadPatient.Name = "btnLoadPatient";
            this.btnLoadPatient.Size = new System.Drawing.Size(75, 25);
            this.btnLoadPatient.TabIndex = 3;
            this.btnLoadPatient.Text = "Load Patient";
            this.btnLoadPatient.UseVisualStyleBackColor = true;
            this.btnLoadPatient.Click += new System.EventHandler(this.btnLoadPatient_Click_1);
            this.btnLoadPatient.MouseCaptureChanged += new System.EventHandler(this.btnLoadPatient_Click);
            // 
            // grpPatientDetails
            // 
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
            this.grpPatientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatientDetails.Location = new System.Drawing.Point(358, 175);
            this.grpPatientDetails.Name = "grpPatientDetails";
            this.grpPatientDetails.Size = new System.Drawing.Size(388, 260);
            this.grpPatientDetails.TabIndex = 4;
            this.grpPatientDetails.TabStop = false;
            this.grpPatientDetails.Text = "Patient Details                                                ";
            this.grpPatientDetails.Enter += new System.EventHandler(this.grpPatientDetails_Enter);
            this.grpPatientDetails.MouseCaptureChanged += new System.EventHandler(this.btnLoadPatient_Click);
            // 
            // lblCurrentDoshaValue
            // 
            this.lblCurrentDoshaValue.AutoSize = true;
            this.lblCurrentDoshaValue.Location = new System.Drawing.Point(124, 177);
            this.lblCurrentDoshaValue.Name = "lblCurrentDoshaValue";
            this.lblCurrentDoshaValue.Size = new System.Drawing.Size(16, 22);
            this.lblCurrentDoshaValue.TabIndex = 12;
            this.lblCurrentDoshaValue.Text = "-";
            // 
            // lblPatientBloodValue
            // 
            this.lblPatientBloodValue.AutoSize = true;
            this.lblPatientBloodValue.Location = new System.Drawing.Point(124, 145);
            this.lblPatientBloodValue.Name = "lblPatientBloodValue";
            this.lblPatientBloodValue.Size = new System.Drawing.Size(16, 22);
            this.lblPatientBloodValue.TabIndex = 11;
            this.lblPatientBloodValue.Text = "-";
            // 
            // lblPatientGenderValue
            // 
            this.lblPatientGenderValue.AutoSize = true;
            this.lblPatientGenderValue.Location = new System.Drawing.Point(124, 114);
            this.lblPatientGenderValue.Name = "lblPatientGenderValue";
            this.lblPatientGenderValue.Size = new System.Drawing.Size(16, 22);
            this.lblPatientGenderValue.TabIndex = 10;
            this.lblPatientGenderValue.Text = "-";
            // 
            // lblPatientAgeValue
            // 
            this.lblPatientAgeValue.AutoSize = true;
            this.lblPatientAgeValue.Location = new System.Drawing.Point(124, 88);
            this.lblPatientAgeValue.Name = "lblPatientAgeValue";
            this.lblPatientAgeValue.Size = new System.Drawing.Size(16, 22);
            this.lblPatientAgeValue.TabIndex = 9;
            this.lblPatientAgeValue.Text = "-";
            // 
            // lblPatientNameValue
            // 
            this.lblPatientNameValue.AutoSize = true;
            this.lblPatientNameValue.Location = new System.Drawing.Point(124, 61);
            this.lblPatientNameValue.Name = "lblPatientNameValue";
            this.lblPatientNameValue.Size = new System.Drawing.Size(16, 22);
            this.lblPatientNameValue.TabIndex = 8;
            this.lblPatientNameValue.Text = "-";
            // 
            // lblPatientIDDValue
            // 
            this.lblPatientIDDValue.AutoSize = true;
            this.lblPatientIDDValue.Location = new System.Drawing.Point(124, 34);
            this.lblPatientIDDValue.Name = "lblPatientIDDValue";
            this.lblPatientIDDValue.Size = new System.Drawing.Size(16, 22);
            this.lblPatientIDDValue.TabIndex = 7;
            this.lblPatientIDDValue.Text = "-";
            // 
            // lblPatientIDValue
            // 
            this.lblPatientIDValue.AutoSize = true;
            this.lblPatientIDValue.Location = new System.Drawing.Point(83, 34);
            this.lblPatientIDValue.Name = "lblPatientIDValue";
            this.lblPatientIDValue.Size = new System.Drawing.Size(0, 22);
            this.lblPatientIDValue.TabIndex = 6;
            // 
            // lblCurrentDosha
            // 
            this.lblCurrentDosha.AutoSize = true;
            this.lblCurrentDosha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDosha.Location = new System.Drawing.Point(10, 177);
            this.lblCurrentDosha.Name = "lblCurrentDosha";
            this.lblCurrentDosha.Size = new System.Drawing.Size(129, 20);
            this.lblCurrentDosha.TabIndex = 5;
            this.lblCurrentDosha.Text = "Current Dosha :";
            // 
            // lblBlood
            // 
            this.lblBlood.AutoSize = true;
            this.lblBlood.Location = new System.Drawing.Point(7, 145);
            this.lblBlood.Name = "lblBlood";
            this.lblBlood.Size = new System.Drawing.Size(121, 22);
            this.lblBlood.TabIndex = 4;
            this.lblBlood.Text = "Blood Group :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(7, 114);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(80, 22);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(7, 88);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(52, 22);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age :";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(7, 61);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(128, 22);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "Patient Name :";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(7, 34);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(98, 22);
            this.lblPatientID.TabIndex = 0;
            this.lblPatientID.Text = "Patient ID :";
            this.lblPatientID.Click += new System.EventHandler(this.lblPatientID_Click);
            // 
            // cmbPatient
            // 
            this.cmbPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(486, 133);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(170, 24);
            this.cmbPatient.TabIndex = 6;
            this.cmbPatient.MouseCaptureChanged += new System.EventHandler(this.btnLoadPatient_Click);
            // 
            // grpQuestions
            // 
            this.grpQuestions.Controls.Add(this.btnFinish);
            this.grpQuestions.Controls.Add(this.btnNext);
            this.grpQuestions.Controls.Add(this.btnPrevious);
            this.grpQuestions.Controls.Add(this.rbOption3);
            this.grpQuestions.Controls.Add(this.rbOption2);
            this.grpQuestions.Controls.Add(this.rbOption1);
            this.grpQuestions.Controls.Add(this.lblQuestion);
            this.grpQuestions.Controls.Add(this.lblQuestionNo);
            this.grpQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQuestions.Location = new System.Drawing.Point(752, 352);
            this.grpQuestions.Name = "grpQuestions";
            this.grpQuestions.Size = new System.Drawing.Size(340, 280);
            this.grpQuestions.TabIndex = 7;
            this.grpQuestions.TabStop = false;
            this.grpQuestions.Text = "Dosha Questionnaire";
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(214, 224);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(79, 36);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(116, 224);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 36);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(17, 224);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(79, 36);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // rbOption3
            // 
            this.rbOption3.AutoSize = true;
            this.rbOption3.Location = new System.Drawing.Point(17, 188);
            this.rbOption3.Name = "rbOption3";
            this.rbOption3.Size = new System.Drawing.Size(115, 29);
            this.rbOption3.TabIndex = 4;
            this.rbOption3.TabStop = true;
            this.rbOption3.Text = "Option 3";
            this.rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            this.rbOption2.AutoSize = true;
            this.rbOption2.Location = new System.Drawing.Point(17, 153);
            this.rbOption2.Name = "rbOption2";
            this.rbOption2.Size = new System.Drawing.Size(115, 29);
            this.rbOption2.TabIndex = 3;
            this.rbOption2.TabStop = true;
            this.rbOption2.Text = "Option 2";
            this.rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption1
            // 
            this.rbOption1.AutoSize = true;
            this.rbOption1.Location = new System.Drawing.Point(17, 118);
            this.rbOption1.Name = "rbOption1";
            this.rbOption1.Size = new System.Drawing.Size(115, 29);
            this.rbOption1.TabIndex = 2;
            this.rbOption1.TabStop = true;
            this.rbOption1.Text = "Option 1";
            this.rbOption1.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(16, 73);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(215, 20);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Question appears here...";
            // 
            // lblQuestionNo
            // 
            this.lblQuestionNo.AutoSize = true;
            this.lblQuestionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNo.Location = new System.Drawing.Point(13, 33);
            this.lblQuestionNo.Name = "lblQuestionNo";
            this.lblQuestionNo.Size = new System.Drawing.Size(158, 22);
            this.lblQuestionNo.TabIndex = 0;
            this.lblQuestionNo.Text = "Question 1 of 10";
            // 
            // StaffDoshaProfiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::clinicManagement.Properties.Resources.dosha_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 676);
            this.Controls.Add(this.grpQuestions);
            this.Controls.Add(this.cmbPatient);
            this.Controls.Add(this.grpPatientDetails);
            this.Controls.Add(this.btnLoadPatient);
            this.Controls.Add(this.lblSelectPatient);
            this.Controls.Add(this.lblTitle);
            this.Name = "StaffDoshaProfiler";
            this.Text = "Dosha Questionnaire";
            this.Load += new System.EventHandler(this.StaffDoshaProfiler_Load);
            this.grpPatientDetails.ResumeLayout(false);
            this.grpPatientDetails.PerformLayout();
            this.grpQuestions.ResumeLayout(false);
            this.grpQuestions.PerformLayout();
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
        private System.Windows.Forms.Label lblCurrentDoshaValue;
        private System.Windows.Forms.Label lblPatientBloodValue;
        private System.Windows.Forms.Label lblPatientGenderValue;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.GroupBox grpQuestions;
        private System.Windows.Forms.RadioButton rbOption1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblQuestionNo;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.RadioButton rbOption3;
        private System.Windows.Forms.RadioButton rbOption2;
    }
}