namespace clinicManagement
{
    partial class ucManageAppointment
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
            this.lblManageHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchInput = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelNewTimeSlot = new System.Windows.Forms.Label();
            this.cmbNewTimeSlot = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatusUpdate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateAppointment = new System.Windows.Forms.Button();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.lblAssignDoctor = new System.Windows.Forms.Label();
            this.cmbAssignDoctor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblManageHeader
            // 
            this.lblManageHeader.AutoSize = true;
            this.lblManageHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageHeader.Location = new System.Drawing.Point(261, 51);
            this.lblManageHeader.Name = "lblManageHeader";
            this.lblManageHeader.Size = new System.Drawing.Size(350, 31);
            this.lblManageHeader.TabIndex = 0;
            this.lblManageHeader.Text = "Manage / Modify Appointment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Appointment (ID or Patient NIC):";
            // 
            // txtSearchInput
            // 
            this.txtSearchInput.Location = new System.Drawing.Point(575, 167);
            this.txtSearchInput.Name = "txtSearchInput";
            this.txtSearchInput.Size = new System.Drawing.Size(200, 22);
            this.txtSearchInput.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(675, 195);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Find Record";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // labelNewTimeSlot
            // 
            this.labelNewTimeSlot.AutoSize = true;
            this.labelNewTimeSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewTimeSlot.Location = new System.Drawing.Point(250, 332);
            this.labelNewTimeSlot.Name = "labelNewTimeSlot";
            this.labelNewTimeSlot.Size = new System.Drawing.Size(132, 22);
            this.labelNewTimeSlot.TabIndex = 4;
            this.labelNewTimeSlot.Text = "New Time Slot:";
            this.labelNewTimeSlot.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbNewTimeSlot
            // 
            this.cmbNewTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewTimeSlot.FormattingEnabled = true;
            this.cmbNewTimeSlot.Items.AddRange(new object[] {
            "09:00 AM - 10:00 AM",
            "10:00 AM - 11:00 AM",
            "11:00 AM - 12:00 PM",
            "02:00 PM - 03:00 PM"});
            this.cmbNewTimeSlot.Location = new System.Drawing.Point(575, 334);
            this.cmbNewTimeSlot.Name = "cmbNewTimeSlot";
            this.cmbNewTimeSlot.Size = new System.Drawing.Size(200, 24);
            this.cmbNewTimeSlot.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Update Status:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbStatusUpdate
            // 
            this.cmbStatusUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusUpdate.FormattingEnabled = true;
            this.cmbStatusUpdate.Items.AddRange(new object[] {
            "Scheduled",
            "",
            "Completed",
            "",
            "Cancelled"});
            this.cmbStatusUpdate.Location = new System.Drawing.Point(525, 435);
            this.cmbStatusUpdate.Name = "cmbStatusUpdate";
            this.cmbStatusUpdate.Size = new System.Drawing.Size(250, 24);
            this.cmbStatusUpdate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reschedule Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(525, 269);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btnUpdateAppointment
            // 
            this.btnUpdateAppointment.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUpdateAppointment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAppointment.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateAppointment.Location = new System.Drawing.Point(170, 510);
            this.btnUpdateAppointment.Name = "btnUpdateAppointment";
            this.btnUpdateAppointment.Size = new System.Drawing.Size(209, 35);
            this.btnUpdateAppointment.TabIndex = 10;
            this.btnUpdateAppointment.Text = "Save Modifications";
            this.btnUpdateAppointment.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteAppointment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAppointment.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteAppointment.Location = new System.Drawing.Point(650, 510);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(212, 35);
            this.btnDeleteAppointment.TabIndex = 11;
            this.btnDeleteAppointment.Text = "Cancel Appointment";
            this.btnDeleteAppointment.UseVisualStyleBackColor = false;
            // 
            // lblAssignDoctor
            // 
            this.lblAssignDoctor.AutoSize = true;
            this.lblAssignDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignDoctor.Location = new System.Drawing.Point(247, 383);
            this.lblAssignDoctor.Name = "lblAssignDoctor";
            this.lblAssignDoctor.Size = new System.Drawing.Size(122, 22);
            this.lblAssignDoctor.TabIndex = 12;
            this.lblAssignDoctor.Text = "Assign Doctor";
            // 
            // cmbAssignDoctor
            // 
            this.cmbAssignDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssignDoctor.FormattingEnabled = true;
            this.cmbAssignDoctor.Items.AddRange(new object[] {
            "09:00 AM - 10:00 AM",
            "10:00 AM - 11:00 AM",
            "11:00 AM - 12:00 PM",
            "02:00 PM - 03:00 PM"});
            this.cmbAssignDoctor.Location = new System.Drawing.Point(575, 381);
            this.cmbAssignDoctor.Name = "cmbAssignDoctor";
            this.cmbAssignDoctor.Size = new System.Drawing.Size(200, 24);
            this.cmbAssignDoctor.TabIndex = 13;
            // 
            // ucManageAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbAssignDoctor);
            this.Controls.Add(this.lblAssignDoctor);
            this.Controls.Add(this.btnDeleteAppointment);
            this.Controls.Add(this.btnUpdateAppointment);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbStatusUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbNewTimeSlot);
            this.Controls.Add(this.labelNewTimeSlot);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblManageHeader);
            this.Name = "ucManageAppointment";
            this.Size = new System.Drawing.Size(1104, 677);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchInput;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelNewTimeSlot;
        private System.Windows.Forms.ComboBox cmbNewTimeSlot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatusUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnUpdateAppointment;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Label lblAssignDoctor;
        private System.Windows.Forms.ComboBox cmbAssignDoctor;
    }
}
