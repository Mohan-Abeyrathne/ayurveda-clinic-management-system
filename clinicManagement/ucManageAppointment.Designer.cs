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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNewTimeSlot = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatusUpdate = new System.Windows.Forms.ComboBox();
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Appointment (ID or Patient NIC):";
            // 
            // txtSearchInput
            // 
            this.txtSearchInput.Location = new System.Drawing.Point(410, 177);
            this.txtSearchInput.Name = "txtSearchInput";
            this.txtSearchInput.Size = new System.Drawing.Size(200, 22);
            this.txtSearchInput.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(627, 177);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Find Record";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Time Slot:";
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
            this.cmbNewTimeSlot.Location = new System.Drawing.Point(369, 275);
            this.cmbNewTimeSlot.Name = "cmbNewTimeSlot";
            this.cmbNewTimeSlot.Size = new System.Drawing.Size(121, 24);
            this.cmbNewTimeSlot.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
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
            this.cmbStatusUpdate.Location = new System.Drawing.Point(369, 336);
            this.cmbStatusUpdate.Name = "cmbStatusUpdate";
            this.cmbStatusUpdate.Size = new System.Drawing.Size(250, 24);
            this.cmbStatusUpdate.TabIndex = 7;
            // 
            // ucManageAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbStatusUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbNewTimeSlot);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNewTimeSlot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatusUpdate;
    }
}
