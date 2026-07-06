namespace clinicManagement
{
    partial class UC_PharmacyDashboard
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
            this.pnlAlertsCard = new System.Windows.Forms.Panel();
            this.lblAlertCount = new System.Windows.Forms.Label();
            this.lblAlertTitle = new System.Windows.Forms.Label();
            this.pnlTotalItemsCard = new System.Windows.Forms.Panel();
            this.lblTotalItemsCount = new System.Windows.Forms.Label();
            this.lblTotalItemsTitle = new System.Windows.Forms.Label();
            this.pnlAssetValueCard = new System.Windows.Forms.Panel();
            this.lblAssetValue = new System.Windows.Forms.Label();
            this.lblAssetTitle = new System.Windows.Forms.Label();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.dgvLowStock = new System.Windows.Forms.DataGridView();
            this.pnlAlertsCard.SuspendLayout();
            this.pnlTotalItemsCard.SuspendLayout();
            this.pnlAssetValueCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAlertsCard
            // 
            this.pnlAlertsCard.BackColor = System.Drawing.Color.MistyRose;
            this.pnlAlertsCard.Controls.Add(this.lblAlertCount);
            this.pnlAlertsCard.Controls.Add(this.lblAlertTitle);
            this.pnlAlertsCard.Location = new System.Drawing.Point(150, 200);
            this.pnlAlertsCard.Name = "pnlAlertsCard";
            this.pnlAlertsCard.Size = new System.Drawing.Size(244, 140);
            this.pnlAlertsCard.TabIndex = 0;
            this.pnlAlertsCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAlertsCard_Paint);
            // 
            // lblAlertCount
            // 
            this.lblAlertCount.AutoSize = true;
            this.lblAlertCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertCount.ForeColor = System.Drawing.Color.Crimson;
            this.lblAlertCount.Location = new System.Drawing.Point(103, 13);
            this.lblAlertCount.Name = "lblAlertCount";
            this.lblAlertCount.Size = new System.Drawing.Size(49, 54);
            this.lblAlertCount.TabIndex = 6;
            this.lblAlertCount.Text = "0";
            this.lblAlertCount.Click += new System.EventHandler(this.lblAlertCount_Click);
            // 
            // lblAlertTitle
            // 
            this.lblAlertTitle.AutoSize = true;
            this.lblAlertTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertTitle.ForeColor = System.Drawing.Color.Crimson;
            this.lblAlertTitle.Location = new System.Drawing.Point(31, 79);
            this.lblAlertTitle.Name = "lblAlertTitle";
            this.lblAlertTitle.Size = new System.Drawing.Size(188, 29);
            this.lblAlertTitle.TabIndex = 2;
            this.lblAlertTitle.Text = "Low Stock Items";
            this.lblAlertTitle.Click += new System.EventHandler(this.lblAlertTitle_Click);
            // 
            // pnlTotalItemsCard
            // 
            this.pnlTotalItemsCard.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlTotalItemsCard.Controls.Add(this.lblTotalItemsCount);
            this.pnlTotalItemsCard.Controls.Add(this.lblTotalItemsTitle);
            this.pnlTotalItemsCard.Location = new System.Drawing.Point(150, 42);
            this.pnlTotalItemsCard.Name = "pnlTotalItemsCard";
            this.pnlTotalItemsCard.Size = new System.Drawing.Size(244, 140);
            this.pnlTotalItemsCard.TabIndex = 1;
            this.pnlTotalItemsCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTotalItemsCard_Paint);
            // 
            // lblTotalItemsCount
            // 
            this.lblTotalItemsCount.AutoSize = true;
            this.lblTotalItemsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemsCount.Location = new System.Drawing.Point(103, 19);
            this.lblTotalItemsCount.Name = "lblTotalItemsCount";
            this.lblTotalItemsCount.Size = new System.Drawing.Size(49, 54);
            this.lblTotalItemsCount.TabIndex = 7;
            this.lblTotalItemsCount.Text = "0";
            this.lblTotalItemsCount.Click += new System.EventHandler(this.lblTotalItemsCount_Click);
            // 
            // lblTotalItemsTitle
            // 
            this.lblTotalItemsTitle.AutoSize = true;
            this.lblTotalItemsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemsTitle.Location = new System.Drawing.Point(20, 94);
            this.lblTotalItemsTitle.Name = "lblTotalItemsTitle";
            this.lblTotalItemsTitle.Size = new System.Drawing.Size(199, 25);
            this.lblTotalItemsTitle.TabIndex = 3;
            this.lblTotalItemsTitle.Text = "Registered Medicines";
            this.lblTotalItemsTitle.Click += new System.EventHandler(this.lblTotalItemsTitle_Click);
            // 
            // pnlAssetValueCard
            // 
            this.pnlAssetValueCard.BackColor = System.Drawing.Color.LightGreen;
            this.pnlAssetValueCard.Controls.Add(this.lblAssetValue);
            this.pnlAssetValueCard.Controls.Add(this.lblAssetTitle);
            this.pnlAssetValueCard.Location = new System.Drawing.Point(426, 42);
            this.pnlAssetValueCard.Name = "pnlAssetValueCard";
            this.pnlAssetValueCard.Size = new System.Drawing.Size(285, 298);
            this.pnlAssetValueCard.TabIndex = 1;
            this.pnlAssetValueCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAssetValueCard_Paint);
            // 
            // lblAssetValue
            // 
            this.lblAssetValue.AutoSize = true;
            this.lblAssetValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetValue.Location = new System.Drawing.Point(42, 111);
            this.lblAssetValue.Name = "lblAssetValue";
            this.lblAssetValue.Size = new System.Drawing.Size(118, 29);
            this.lblAssetValue.TabIndex = 7;
            this.lblAssetValue.Text = "LKR 0.00";
            // 
            // lblAssetTitle
            // 
            this.lblAssetTitle.AutoSize = true;
            this.lblAssetTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetTitle.Location = new System.Drawing.Point(42, 218);
            this.lblAssetTitle.Name = "lblAssetTitle";
            this.lblAssetTitle.Size = new System.Drawing.Size(201, 29);
            this.lblAssetTitle.TabIndex = 4;
            this.lblAssetTitle.Text = "Total Stock Value";
            this.lblAssetTitle.Click += new System.EventHandler(this.lblAssetTitle_Click);
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblGridTitle.Location = new System.Drawing.Point(145, 365);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(448, 25);
            this.lblGridTitle.TabIndex = 2;
            this.lblGridTitle.Text = "⚠️ Critical Stock Shortages (Action Required)";
            this.lblGridTitle.Click += new System.EventHandler(this.lblGridTitle_Click);
            // 
            // dgvLowStock
            // 
            this.dgvLowStock.AllowUserToAddRows = false;
            this.dgvLowStock.AllowUserToDeleteRows = false;
            this.dgvLowStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLowStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLowStock.Location = new System.Drawing.Point(150, 402);
            this.dgvLowStock.Name = "dgvLowStock";
            this.dgvLowStock.ReadOnly = true;
            this.dgvLowStock.RowHeadersVisible = false;
            this.dgvLowStock.RowHeadersWidth = 51;
            this.dgvLowStock.RowTemplate.Height = 24;
            this.dgvLowStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLowStock.Size = new System.Drawing.Size(561, 271);
            this.dgvLowStock.TabIndex = 3;
            this.dgvLowStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLowStock_CellContentClick);
            // 
            // UC_PharmacyDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvLowStock);
            this.Controls.Add(this.lblGridTitle);
            this.Controls.Add(this.pnlAssetValueCard);
            this.Controls.Add(this.pnlTotalItemsCard);
            this.Controls.Add(this.pnlAlertsCard);
            this.Name = "UC_PharmacyDashboard";
            this.Size = new System.Drawing.Size(922, 735);
            this.Load += new System.EventHandler(this.UC_PharmacyDashboard_Load);
            this.pnlAlertsCard.ResumeLayout(false);
            this.pnlAlertsCard.PerformLayout();
            this.pnlTotalItemsCard.ResumeLayout(false);
            this.pnlTotalItemsCard.PerformLayout();
            this.pnlAssetValueCard.ResumeLayout(false);
            this.pnlAssetValueCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAlertsCard;
        private System.Windows.Forms.Panel pnlTotalItemsCard;
        private System.Windows.Forms.Panel pnlAssetValueCard;
        private System.Windows.Forms.Label lblAlertCount;
        private System.Windows.Forms.Label lblAlertTitle;
        private System.Windows.Forms.Label lblTotalItemsTitle;
        private System.Windows.Forms.Label lblAssetTitle;
        private System.Windows.Forms.Label lblTotalItemsCount;
        private System.Windows.Forms.Label lblAssetValue;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvLowStock;
    }
}
