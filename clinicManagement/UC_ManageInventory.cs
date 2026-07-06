using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace clinicManagement
{
    public partial class UC_ManageInventory : UserControl
    {

        private string connString = "server=127.0.0.1;user=root;password=;database=clinicmanagement";
        private int selectedMedicineId = -1; 

        public UC_ManageInventory()
        {
            InitializeComponent();
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void UC_ManageInventory_Load(object sender, EventArgs e)
        {
            LoadFullInventory("");

        }

        private void LoadFullInventory(string searchTerm)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            MedicineID AS 'ID',
                            Name AS 'Medicine Name',
                            Type AS 'Type',
                            StockQuantity AS 'Current Stock',
                            LowStockThreshold AS 'Min Limit',
                            CostPerUnit AS 'Cost (LKR)',
                            SellingPrice AS 'Price (LKR)',
                            Manufacturer AS 'Manufacturer'
                        FROM medicines
                        WHERE Name LIKE @search;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvInventory.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading inventory: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pnlRefillAction_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadFullInventory(txtSearch.Text.Trim());

        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvInventory.Rows[e.RowIndex];
                selectedMedicineId = Convert.ToInt32(row.Cells["ID"].Value);
                lblSelectedMedicine.Text = "Selected: " + row.Cells["Medicine Name"].Value.ToString();
                txtAddQuantity.Clear();
                txtAddQuantity.Focus();
            }
        }

        private void lblSelectedMedicine_Click(object sender, EventArgs e)
        {

        }

        private void lblRefillTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblAddQty_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            if (selectedMedicineId == -1)
            {
                MessageBox.Show("Please select a medicine from the list first.", "Selection Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Input Validation
            if (!int.TryParse(txtAddQuantity.Text.Trim(), out int qtyToAdd) || qtyToAdd <= 0)
            {
                MessageBox.Show("Please enter a valid positive whole number for quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        UPDATE medicines 
                        SET StockQuantity = StockQuantity + @qty 
                        WHERE MedicineID = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@qty", qtyToAdd);
                        cmd.Parameters.AddWithValue("@id", selectedMedicineId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Stock updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtAddQuantity.Clear();
                            lblSelectedMedicine.Text = "Selected: None";
                            selectedMedicineId = -1;

                            LoadFullInventory(txtSearch.Text.Trim());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating stock records: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
