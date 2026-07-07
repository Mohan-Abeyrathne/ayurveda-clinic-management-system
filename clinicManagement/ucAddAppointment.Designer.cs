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
            this.btnSaveBooking = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(382, 66);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(315, 62);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Schedule New Appointment\r\n\r\n";
            // 
            // lblSelectPatient
            // 
            this.lblSelectPatient.AutoSize = true;
            this.lblSelectPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPatient.Location = new System.Drawing.Point(285, 163);
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
            this.cmbPatientSelect.Location = new System.Drawing.Point(688, 158);
            this.cmbPatientSelect.Name = "cmbPatientSelect";
            this.cmbPatientSelect.Size = new System.Drawing.Size(121, 31);
            this.cmbPatientSelect.TabIndex = 2;
            // 
            // cmbTimeSlot
            // 
            this.cmbTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeSlot.FormattingEnabled = true;
            this.cmbTimeSlot.Location = new System.Drawing.Point(688, 365);
            this.cmbTimeSlot.Name = "cmbTimeSlot";
            this.cmbTimeSlot.Size = new System.Drawing.Size(121, 24);
            this.cmbTimeSlot.TabIndex = 3;
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDate.Location = new System.Drawing.Point(285, 265);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(159, 20);
            this.lblAppointmentDate.TabIndex = 4;
            this.lblAppointmentDate.Text = "Appointment Date";
            // 
            // lblSelectTimeSlot
            // 
            this.lblSelectTimeSlot.AutoSize = true;
            this.lblSelectTimeSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTimeSlot.Location = new System.Drawing.Point(285, 369);
            this.lblSelectTimeSlot.Name = "lblSelectTimeSlot";
            this.lblSelectTimeSlot.Size = new System.Drawing.Size(148, 20);
            this.lblSelectTimeSlot.TabIndex = 5;
            this.lblSelectTimeSlot.Text = "Select Time Slot";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(688, 265);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(121, 22);
            this.dtpDate.TabIndex = 6;
            // 
            // btnSaveBooking
            // 
            this.btnSaveBooking.AutoSize = true;
            this.btnSaveBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBooking.Location = new System.Drawing.Point(406, 493);
            this.btnSaveBooking.Name = "btnSaveBooking";
            this.btnSaveBooking.Size = new System.Drawing.Size(291, 20);
            this.btnSaveBooking.TabIndex = 7;
            this.btnSaveBooking.Text = "Confirm Booking and Issue Token";
            // 
            // ucAddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSaveBooking);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblSelectTimeSlot);
            this.Controls.Add(this.lblAppointmentDate);
            this.Controls.Add(this.cmbTimeSlot);
            this.Controls.Add(this.cmbPatientSelect);
            this.Controls.Add(this.lblSelectPatient);
            this.Controls.Add(this.lblHeader);
            this.Name = "ucAddAppointment";
            this.Size = new System.Drawing.Size(1049, 786);
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
        private System.Windows.Forms.Label btnSaveBooking;
    }
}
