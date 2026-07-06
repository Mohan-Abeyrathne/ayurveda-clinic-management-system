namespace clinicManagement
{
    partial class UC_ManageInventory
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.pnlRefillAction = new System.Windows.Forms.Panel();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.txtAddQuantity = new System.Windows.Forms.TextBox();
            this.lblAddQty = new System.Windows.Forms.Label();
            this.lblSelectedMedicine = new System.Windows.Forms.Label();
            this.lblRefillTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.pnlRefillAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(58, 37);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(200, 29);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search Medicine:";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(273, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(221, 34);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(62, 92);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(366, 408);
            this.dgvInventory.TabIndex = 2;
            this.dgvInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellClick);
            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellContentClick);
            // 
            // pnlRefillAction
            // 
            this.pnlRefillAction.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlRefillAction.Controls.Add(this.btnUpdateStock);
            this.pnlRefillAction.Controls.Add(this.txtAddQuantity);
            this.pnlRefillAction.Controls.Add(this.lblAddQty);
            this.pnlRefillAction.Controls.Add(this.lblSelectedMedicine);
            this.pnlRefillAction.Controls.Add(this.lblRefillTitle);
            this.pnlRefillAction.Location = new System.Drawing.Point(452, 92);
            this.pnlRefillAction.Name = "pnlRefillAction";
            this.pnlRefillAction.Size = new System.Drawing.Size(409, 408);
            this.pnlRefillAction.TabIndex = 3;
            this.pnlRefillAction.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRefillAction_Paint);
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.BackColor = System.Drawing.Color.LightGreen;
            this.btnUpdateStock.FlatAppearance.BorderSize = 0;
            this.btnUpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStock.Location = new System.Drawing.Point(139, 252);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(113, 63);
            this.btnUpdateStock.TabIndex = 7;
            this.btnUpdateStock.Text = "Confirm Refill";
            this.btnUpdateStock.UseVisualStyleBackColor = false;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // txtAddQuantity
            // 
            this.txtAddQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddQuantity.Location = new System.Drawing.Point(230, 169);
            this.txtAddQuantity.Name = "txtAddQuantity";
            this.txtAddQuantity.Size = new System.Drawing.Size(72, 34);
            this.txtAddQuantity.TabIndex = 4;
            // 
            // lblAddQty
            // 
            this.lblAddQty.AutoSize = true;
            this.lblAddQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddQty.Location = new System.Drawing.Point(32, 171);
            this.lblAddQty.Name = "lblAddQty";
            this.lblAddQty.Size = new System.Drawing.Size(181, 29);
            this.lblAddQty.TabIndex = 5;
            this.lblAddQty.Text = "Quantity to Add:";
            this.lblAddQty.Click += new System.EventHandler(this.lblAddQty_Click);
            // 
            // lblSelectedMedicine
            // 
            this.lblSelectedMedicine.AutoSize = true;
            this.lblSelectedMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedMedicine.ForeColor = System.Drawing.Color.Blue;
            this.lblSelectedMedicine.Location = new System.Drawing.Point(32, 100);
            this.lblSelectedMedicine.Name = "lblSelectedMedicine";
            this.lblSelectedMedicine.Size = new System.Drawing.Size(161, 25);
            this.lblSelectedMedicine.TabIndex = 4;
            this.lblSelectedMedicine.Text = "Selected: None";
            this.lblSelectedMedicine.Click += new System.EventHandler(this.lblSelectedMedicine_Click);
            // 
            // lblRefillTitle
            // 
            this.lblRefillTitle.AutoSize = true;
            this.lblRefillTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefillTitle.Location = new System.Drawing.Point(21, 16);
            this.lblRefillTitle.Name = "lblRefillTitle";
            this.lblRefillTitle.Size = new System.Drawing.Size(293, 32);
            this.lblRefillTitle.TabIndex = 4;
            this.lblRefillTitle.Text = "Update Stock Levels";
            this.lblRefillTitle.Click += new System.EventHandler(this.lblRefillTitle_Click);
            // 
            // UC_ManageInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRefillAction);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Name = "UC_ManageInventory";
            this.Size = new System.Drawing.Size(922, 735);
            this.Load += new System.EventHandler(this.UC_ManageInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.pnlRefillAction.ResumeLayout(false);
            this.pnlRefillAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Panel pnlRefillAction;
        private System.Windows.Forms.Label lblRefillTitle;
        private System.Windows.Forms.Label lblSelectedMedicine;
        private System.Windows.Forms.Label lblAddQty;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.TextBox txtAddQuantity;
    }
}
