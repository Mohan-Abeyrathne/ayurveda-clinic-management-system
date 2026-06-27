namespace AyurvedaClinicSystem
{
    partial class DiagnosisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvDiagnosis = new System.Windows.Forms.DataGridView();
            this.btnReport = new System.Windows.Forms.Button();
            this.txtDiagnosisID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtBloodGroup = new System.Windows.Forms.TextBox();
            this.txtDosha = new System.Windows.Forms.TextBox();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.txtDoctorNotes = new System.Windows.Forms.TextBox();
            this.txtPulseDiagnosis = new System.Windows.Forms.TextBox();
            this.txtSymptoms = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosis)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightBlue;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(942, 430);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 38);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightBlue;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(942, 363);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 38);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(942, 307);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 36);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Crimson;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(467, 668);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 42);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvDiagnosis
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.dgvDiagnosis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDiagnosis.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnosis.Location = new System.Drawing.Point(150, 748);
            this.dgvDiagnosis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDiagnosis.Name = "dgvDiagnosis";
            this.dgvDiagnosis.RowHeadersVisible = false;
            this.dgvDiagnosis.RowHeadersWidth = 51;
            this.dgvDiagnosis.RowTemplate.Height = 24;
            this.dgvDiagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiagnosis.Size = new System.Drawing.Size(712, 245);
            this.dgvDiagnosis.TabIndex = 21;
            this.dgvDiagnosis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnosis_CellClick);
            this.dgvDiagnosis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnosis_CellContentClick);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.LightBlue;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Location = new System.Drawing.Point(942, 785);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(93, 58);
            this.btnReport.TabIndex = 23;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txtDiagnosisID
            // 
            this.txtDiagnosisID.Location = new System.Drawing.Point(272, 748);
            this.txtDiagnosisID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiagnosisID.Name = "txtDiagnosisID";
            this.txtDiagnosisID.Size = new System.Drawing.Size(112, 27);
            this.txtDiagnosisID.TabIndex = 24;
            this.txtDiagnosisID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtPatientName);
            this.panel1.Controls.Add(this.txtBloodGroup);
            this.panel1.Controls.Add(this.txtDosha);
            this.panel1.Controls.Add(this.txtDiagnosis);
            this.panel1.Controls.Add(this.txtDoctorNotes);
            this.panel1.Controls.Add(this.txtPulseDiagnosis);
            this.panel1.Controls.Add(this.txtSymptoms);
            this.panel1.Controls.Add(this.txtPatientID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(132, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 508);
            this.panel1.TabIndex = 25;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(646, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 27);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.White;
            this.txtPatientName.Location = new System.Drawing.Point(213, 66);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(396, 27);
            this.txtPatientName.TabIndex = 32;
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.BackColor = System.Drawing.Color.White;
            this.txtBloodGroup.Location = new System.Drawing.Point(213, 115);
            this.txtBloodGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.ReadOnly = true;
            this.txtBloodGroup.Size = new System.Drawing.Size(396, 27);
            this.txtBloodGroup.TabIndex = 31;
            // 
            // txtDosha
            // 
            this.txtDosha.BackColor = System.Drawing.Color.White;
            this.txtDosha.Location = new System.Drawing.Point(213, 162);
            this.txtDosha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDosha.Name = "txtDosha";
            this.txtDosha.ReadOnly = true;
            this.txtDosha.Size = new System.Drawing.Size(396, 27);
            this.txtDosha.TabIndex = 30;
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Location = new System.Drawing.Point(213, 437);
            this.txtDiagnosis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiagnosis.Multiline = true;
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(396, 55);
            this.txtDiagnosis.TabIndex = 29;
            // 
            // txtDoctorNotes
            // 
            this.txtDoctorNotes.Location = new System.Drawing.Point(213, 361);
            this.txtDoctorNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDoctorNotes.Multiline = true;
            this.txtDoctorNotes.Name = "txtDoctorNotes";
            this.txtDoctorNotes.Size = new System.Drawing.Size(396, 52);
            this.txtDoctorNotes.TabIndex = 28;
            // 
            // txtPulseDiagnosis
            // 
            this.txtPulseDiagnosis.Location = new System.Drawing.Point(213, 291);
            this.txtPulseDiagnosis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPulseDiagnosis.Multiline = true;
            this.txtPulseDiagnosis.Name = "txtPulseDiagnosis";
            this.txtPulseDiagnosis.Size = new System.Drawing.Size(396, 52);
            this.txtPulseDiagnosis.TabIndex = 27;
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.Location = new System.Drawing.Point(213, 215);
            this.txtSymptoms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSymptoms.Multiline = true;
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.Size = new System.Drawing.Size(396, 61);
            this.txtSymptoms.TabIndex = 26;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(213, 16);
            this.txtPatientID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(396, 27);
            this.txtPatientID.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Diagnosis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Doctor notes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Pulse Diagnosis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Symptoms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Dosha Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Blood Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Patient Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Patient ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Firebrick;
            this.label10.Location = new System.Drawing.Point(32, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(955, 54);
            this.label10.TabIndex = 26;
            this.label10.Text = "PATIENT DIAGNOSIS AND CLINICAL EVALUATION";
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1105, 1055);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDiagnosisID);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dgvDiagnosis);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DiagnosisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnosis Management";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosis)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvDiagnosis;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox txtDiagnosisID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtBloodGroup;
        private System.Windows.Forms.TextBox txtDosha;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.TextBox txtDoctorNotes;
        private System.Windows.Forms.TextBox txtPulseDiagnosis;
        private System.Windows.Forms.TextBox txtSymptoms;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
    }
}

