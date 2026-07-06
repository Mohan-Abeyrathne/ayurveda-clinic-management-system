namespace ClinicManagementSystem
{
    partial class PrescriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.cmbFrequency = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.cmbMedicine = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPrescription = new System.Windows.Forms.DataGridView();
            this.Medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instructions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtDiagnosis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtPatientID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.BackColor = System.Drawing.Color.Honeydew;
            this.txtDiagnosis.Location = new System.Drawing.Point(154, 112);
            this.txtDiagnosis.Multiline = true;
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(367, 46);
            this.txtDiagnosis.TabIndex = 6;
            this.txtDiagnosis.TextChanged += new System.EventHandler(this.txtDiagnosis_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Diagnosis";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.Honeydew;
            this.txtPatientName.Location = new System.Drawing.Point(154, 70);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(367, 22);
            this.txtPatientName.TabIndex = 4;
            this.txtPatientName.TextChanged += new System.EventHandler(this.txtPatientName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(566, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPatientID
            // 
            this.txtPatientID.BackColor = System.Drawing.Color.Honeydew;
            this.txtPatientID.Location = new System.Drawing.Point(154, 37);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(367, 22);
            this.txtPatientID.TabIndex = 1;
            this.txtPatientID.TextChanged += new System.EventHandler(this.txtPatientID_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnAddMedicine);
            this.groupBox2.Controls.Add(this.txtInstructions);
            this.groupBox2.Controls.Add(this.numDuration);
            this.groupBox2.Controls.Add(this.cmbFrequency);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDosage);
            this.groupBox2.Controls.Add(this.cmbMedicine);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 304);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prescription Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddMedicine.Location = new System.Drawing.Point(255, 265);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(140, 24);
            this.btnAddMedicine.TabIndex = 5;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // txtInstructions
            // 
            this.txtInstructions.BackColor = System.Drawing.Color.Honeydew;
            this.txtInstructions.Location = new System.Drawing.Point(154, 201);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(367, 49);
            this.txtInstructions.TabIndex = 4;
            // 
            // numDuration
            // 
            this.numDuration.BackColor = System.Drawing.Color.Honeydew;
            this.numDuration.Location = new System.Drawing.Point(154, 151);
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(367, 22);
            this.numDuration.TabIndex = 3;
            // 
            // cmbFrequency
            // 
            this.cmbFrequency.BackColor = System.Drawing.Color.Honeydew;
            this.cmbFrequency.FormattingEnabled = true;
            this.cmbFrequency.Items.AddRange(new object[] {
            "Once Daily",
            "Twice Daily",
            "Three Times Daily",
            "Before Meals",
            "After Meals",
            "Morning",
            "Night"});
            this.cmbFrequency.Location = new System.Drawing.Point(154, 108);
            this.cmbFrequency.Name = "cmbFrequency";
            this.cmbFrequency.Size = new System.Drawing.Size(367, 24);
            this.cmbFrequency.TabIndex = 2;
            this.cmbFrequency.SelectedIndexChanged += new System.EventHandler(this.cmbFrequency_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Duration (Days)\n";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Instructions\r\n";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtDosage
            // 
            this.txtDosage.BackColor = System.Drawing.Color.Honeydew;
            this.txtDosage.Location = new System.Drawing.Point(154, 72);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(367, 22);
            this.txtDosage.TabIndex = 1;
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.BackColor = System.Drawing.Color.Honeydew;
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.Location = new System.Drawing.Point(154, 36);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.Size = new System.Drawing.Size(367, 24);
            this.cmbMedicine.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Frequency";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medicine";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dosage";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dgvPrescription
            // 
            this.dgvPrescription.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicine,
            this.Dosage,
            this.Frequency,
            this.Duration,
            this.Instructions});
            this.dgvPrescription.Location = new System.Drawing.Point(12, 518);
            this.dgvPrescription.Name = "dgvPrescription";
            this.dgvPrescription.RowHeadersWidth = 51;
            this.dgvPrescription.RowTemplate.Height = 24;
            this.dgvPrescription.Size = new System.Drawing.Size(677, 253);
            this.dgvPrescription.TabIndex = 8;
            this.dgvPrescription.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrescription_CellContentClick);
            // 
            // Medicine
            // 
            this.Medicine.HeaderText = "Medicine";
            this.Medicine.MinimumWidth = 6;
            this.Medicine.Name = "Medicine";
            this.Medicine.Width = 125;
            // 
            // Dosage
            // 
            this.Dosage.HeaderText = "Dosage";
            this.Dosage.MinimumWidth = 6;
            this.Dosage.Name = "Dosage";
            this.Dosage.Width = 125;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.MinimumWidth = 6;
            this.Frequency.Name = "Frequency";
            this.Frequency.Width = 125;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.Width = 125;
            // 
            // Instructions
            // 
            this.Instructions.HeaderText = "Instructions";
            this.Instructions.MinimumWidth = 6;
            this.Instructions.Name = "Instructions";
            this.Instructions.Width = 125;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Location = new System.Drawing.Point(25, 814);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 38);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save Prescription";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PaleGreen;
            this.btnClear.Location = new System.Drawing.Point(288, 814);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 38);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.Location = new System.Drawing.Point(541, 814);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(137, 38);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print Prescription";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(555, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(306, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Prescription  Management";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.dgvPrescription);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(364, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 885);
            this.panel1.TabIndex = 13;
            // 
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PrescriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Prescription Management     ";
            this.Load += new System.EventHandler(this.PrescriptionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.ComboBox cmbFrequency;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.ComboBox cmbMedicine;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvPrescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instructions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
    }
}

