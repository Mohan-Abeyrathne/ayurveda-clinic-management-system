namespace clinicManagement
{
    partial class StaffManageAppoinment
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
            this.oppoinmentpnlsubnavigation = new System.Windows.Forms.Panel();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnViewAllAppointments = new System.Windows.Forms.Button();
            this.btnEditDeleteAppointment = new System.Windows.Forms.Button();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.appoinmentrightpnlsubcontent = new System.Windows.Forms.Panel();
            this.oppoinmentpnlsubnavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // oppoinmentpnlsubnavigation
            // 
            this.oppoinmentpnlsubnavigation.BackColor = System.Drawing.Color.LightGray;
            this.oppoinmentpnlsubnavigation.Controls.Add(this.btnCloseForm);
            this.oppoinmentpnlsubnavigation.Controls.Add(this.btnViewAllAppointments);
            this.oppoinmentpnlsubnavigation.Controls.Add(this.btnEditDeleteAppointment);
            this.oppoinmentpnlsubnavigation.Controls.Add(this.btnAddAppointment);
            this.oppoinmentpnlsubnavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.oppoinmentpnlsubnavigation.Location = new System.Drawing.Point(0, 0);
            this.oppoinmentpnlsubnavigation.Name = "oppoinmentpnlsubnavigation";
            this.oppoinmentpnlsubnavigation.Size = new System.Drawing.Size(323, 745);
            this.oppoinmentpnlsubnavigation.TabIndex = 0;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.Location = new System.Drawing.Point(79, 538);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(162, 78);
            this.btnCloseForm.TabIndex = 4;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            // 
            // btnViewAllAppointments
            // 
            this.btnViewAllAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllAppointments.Location = new System.Drawing.Point(79, 417);
            this.btnViewAllAppointments.Name = "btnViewAllAppointments";
            this.btnViewAllAppointments.Size = new System.Drawing.Size(162, 78);
            this.btnViewAllAppointments.TabIndex = 3;
            this.btnViewAllAppointments.Text = "View All Appointment";
            this.btnViewAllAppointments.UseVisualStyleBackColor = true;
            // 
            // btnEditDeleteAppointment
            // 
            this.btnEditDeleteAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDeleteAppointment.Location = new System.Drawing.Point(79, 303);
            this.btnEditDeleteAppointment.Name = "btnEditDeleteAppointment";
            this.btnEditDeleteAppointment.Size = new System.Drawing.Size(162, 78);
            this.btnEditDeleteAppointment.TabIndex = 2;
            this.btnEditDeleteAppointment.Text = "Manage Appointment";
            this.btnEditDeleteAppointment.UseVisualStyleBackColor = true;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppointment.Location = new System.Drawing.Point(79, 191);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(162, 78);
            this.btnAddAppointment.TabIndex = 1;
            this.btnAddAppointment.Text = "Add Appointment";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // appoinmentrightpnlsubcontent
            // 
            this.appoinmentrightpnlsubcontent.Dock = System.Windows.Forms.DockStyle.Right;
            this.appoinmentrightpnlsubcontent.Location = new System.Drawing.Point(323, 0);
            this.appoinmentrightpnlsubcontent.Name = "appoinmentrightpnlsubcontent";
            this.appoinmentrightpnlsubcontent.Size = new System.Drawing.Size(903, 745);
            this.appoinmentrightpnlsubcontent.TabIndex = 1;
            this.appoinmentrightpnlsubcontent.Paint += new System.Windows.Forms.PaintEventHandler(this.appoinmentrightpnlsubcontent_Paint);
            // 
            // StaffManageAppoinment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 745);
            this.Controls.Add(this.appoinmentrightpnlsubcontent);
            this.Controls.Add(this.oppoinmentpnlsubnavigation);
            this.Name = "StaffManageAppoinment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StaffManageAppoinment";
            this.Load += new System.EventHandler(this.StaffManageAppoinment_Load);
            this.oppoinmentpnlsubnavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel oppoinmentpnlsubnavigation;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnViewAllAppointments;
        private System.Windows.Forms.Button btnEditDeleteAppointment;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Panel appoinmentrightpnlsubcontent;
    }
}