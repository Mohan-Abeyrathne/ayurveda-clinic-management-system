namespace clinicManagement
{
    partial class UC_AddNewMedicine
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtMedicineID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBatchNumber = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuyingPrice = new System.Windows.Forms.Label();
            this.txtBuying = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaveMedicine = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 683);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(438, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "* Ayurveda Clinic Management System *";
            // 
            // txtMedicineID
            // 
            this.txtMedicineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineID.Location = new System.Drawing.Point(245, 74);
            this.txtMedicineID.Name = "txtMedicineID";
            this.txtMedicineID.Size = new System.Drawing.Size(305, 28);
            this.txtMedicineID.TabIndex = 18;
            this.txtMedicineID.TextChanged += new System.EventHandler(this.txtMedicineID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Medicine ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Medicine Name";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineName.Location = new System.Drawing.Point(245, 139);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(305, 28);
            this.txtMedicineName.TabIndex = 21;
            this.txtMedicineName.TextChanged += new System.EventHandler(this.txtMedicineName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Batch Number";
            // 
            // txtBatchNumber
            // 
            this.txtBatchNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchNumber.Location = new System.Drawing.Point(245, 204);
            this.txtBatchNumber.Name = "txtBatchNumber";
            this.txtBatchNumber.Size = new System.Drawing.Size(305, 28);
            this.txtBatchNumber.TabIndex = 23;
            this.txtBatchNumber.TextChanged += new System.EventHandler(this.txtBatchNumber_TextChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Tablets",
            "Syrups",
            "Oils",
            "Powders",
            "Capsules"});
            this.cmbCategory.Location = new System.Drawing.Point(246, 269);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(304, 24);
            this.cmbCategory.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(387, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Category (e.g., Tablets, Syrups, Oils, Powders)\n";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(245, 335);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(305, 28);
            this.txtQuantity.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Quantity / Stock Count";
            // 
            // txtBuyingPrice
            // 
            this.txtBuyingPrice.AutoSize = true;
            this.txtBuyingPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtBuyingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyingPrice.Location = new System.Drawing.Point(117, 354);
            this.txtBuyingPrice.Name = "txtBuyingPrice";
            this.txtBuyingPrice.Size = new System.Drawing.Size(155, 22);
            this.txtBuyingPrice.TabIndex = 29;
            this.txtBuyingPrice.Text = "Buying Price (Rs.)";
            // 
            // txtBuying
            // 
            this.txtBuying.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuying.Location = new System.Drawing.Point(245, 405);
            this.txtBuying.Name = "txtBuying";
            this.txtBuying.Size = new System.Drawing.Size(305, 28);
            this.txtBuying.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 22);
            this.label7.TabIndex = 32;
            this.label7.Text = "Selling Price (Rs.)";
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellingPrice.Location = new System.Drawing.Point(245, 461);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(305, 28);
            this.txtSellingPrice.TabIndex = 33;
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Location = new System.Drawing.Point(122, 503);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(305, 22);
            this.dtpExpiryDate.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(119, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 22);
            this.label8.TabIndex = 35;
            this.label8.Text = "Expiry Date";
            // 
            // btnSaveMedicine
            // 
            this.btnSaveMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMedicine.Location = new System.Drawing.Point(298, 547);
            this.btnSaveMedicine.Name = "btnSaveMedicine";
            this.btnSaveMedicine.Size = new System.Drawing.Size(112, 56);
            this.btnSaveMedicine.TabIndex = 36;
            this.btnSaveMedicine.Text = "Add Medicine";
            this.btnSaveMedicine.UseVisualStyleBackColor = true;
            this.btnSaveMedicine.Click += new System.EventHandler(this.btnSaveMedicine_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(131, 547);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(120, 56);
            this.btnClearFields.TabIndex = 37;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.dtpExpiryDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBuyingPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnClearFields);
            this.panel1.Controls.Add(this.btnSaveMedicine);
            this.panel1.Location = new System.Drawing.Point(123, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 636);
            this.panel1.TabIndex = 38;
            // 
            // UC_AddNewMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSellingPrice);
            this.Controls.Add(this.txtBuying);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtBatchNumber);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.txtMedicineID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "UC_AddNewMedicine";
            this.Size = new System.Drawing.Size(821, 735);
            this.Load += new System.EventHandler(this.UC_AddNewMedicine_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMedicineID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBatchNumber;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtBuyingPrice;
        private System.Windows.Forms.TextBox txtBuying;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSaveMedicine;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Panel panel1;
    }
}
