namespace clinicManagement
{
    partial class ucAddAppointment
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSelectPatient = new System.Windows.Forms.Label();
            this.cmbPatientSelect = new System.Windows.Forms.ComboBox();
            this.cmbTimeSlot = new System.Windows.Forms.ComboBox();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.lblSelectTimeSlot = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSaveBook = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblHeader.Location = new System.Drawing.Point(191, 29);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(315, 62);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Schedule New Appointment\r\n\r\n";
            // 
            // lblSelectPatient
            // 
            this.lblSelectPatient.AutoSize = true;
            this.lblSelectPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPatient.Location = new System.Drawing.Point(74, 151);
            this.lblSelectPatient.Name = "lblSelectPatient";
            this.lblSelectPatient.Size = new System.Drawing.Size(203, 20);
            this.lblSelectPatient.TabIndex = 1;
            this.lblSelectPatient.Text = "Select Patient (NIC/ID)";
            // 
            // cmbPatientSelect
            // 
            this.cmbPatientSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatientSelect.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatientSelect.FormattingEnabled = true;
            this.cmbPatientSelect.Location = new System.Drawing.Point(386, 146);
            this.cmbPatientSelect.Name = "cmbPatientSelect";
            this.cmbPatientSelect.Size = new System.Drawing.Size(151, 31);
            this.cmbPatientSelect.TabIndex = 2;
            // 
            // cmbTimeSlot
            // 
            this.cmbTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeSlot.FormattingEnabled = true;
            this.cmbTimeSlot.Location = new System.Drawing.Point(386, 353);
            this.cmbTimeSlot.Name = "cmbTimeSlot";
            this.cmbTimeSlot.Size = new System.Drawing.Size(151, 24);
            this.cmbTimeSlot.TabIndex = 3;
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDate.Location = new System.Drawing.Point(74, 251);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(159, 20);
            this.lblAppointmentDate.TabIndex = 4;
            this.lblAppointmentDate.Text = "Appointment Date";
            // 
            // lblSelectTimeSlot
            // 
            this.lblSelectTimeSlot.AutoSize = true;
            this.lblSelectTimeSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTimeSlot.Location = new System.Drawing.Point(74, 357);
            this.lblSelectTimeSlot.Name = "lblSelectTimeSlot";
            this.lblSelectTimeSlot.Size = new System.Drawing.Size(148, 20);
            this.lblSelectTimeSlot.TabIndex = 5;
            this.lblSelectTimeSlot.Text = "Select Time Slot";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(386, 251);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(151, 22);
            this.dtpDate.TabIndex = 6;
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSaveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBook.Location = new System.Drawing.Point(281, 460);
            this.btnSaveBook.Name = "btnSaveBook";
            this.btnSaveBook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSaveBook.Size = new System.Drawing.Size(130, 51);
            this.btnSaveBook.TabIndex = 8;
            this.btnSaveBook.Text = "Book Now";
            this.btnSaveBook.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnSaveBook);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.lblSelectTimeSlot);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.lblAppointmentDate);
            this.panel1.Controls.Add(this.lblSelectPatient);
            this.panel1.Controls.Add(this.cmbTimeSlot);
            this.panel1.Controls.Add(this.cmbPatientSelect);
            this.panel1.Location = new System.Drawing.Point(119, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 619);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 704);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "* Ayurveda Clinic Management System *";
            // 
            // ucAddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ucAddAppointment";
            this.Size = new System.Drawing.Size(1049, 786);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSelectPatient;
        private System.Windows.Forms.ComboBox cmbPatientSelect;
        private System.Windows.Forms.ComboBox cmbTimeSlot;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Label lblSelectTimeSlot;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSaveBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}
