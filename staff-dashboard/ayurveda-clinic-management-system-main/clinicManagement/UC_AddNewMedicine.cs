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
    public partial class UC_AddNewMedicine : UserControl
    {
        private string connectionString = "server=localhost;database=clinicmanagement;uid=root;pwd=;";
        public UC_AddNewMedicine()
        {
            InitializeComponent();
        }

        private void UC_AddNewMedicine_Load(object sender, EventArgs e)
        {

        }

        private void txtMedicineID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMedicineName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBatchNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveMedicine_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMedicineName.Text) ||
        string.IsNullOrEmpty(txtBatchNumber.Text) ||
        cmbCategory.SelectedIndex == -1 ||
        string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Please fill in all mandatory fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🎯 UPDATED: Changed txtBuyingPrice.Text to txtBuying.Text
            if (!int.TryParse(txtQuantity.Text, out int quantity) ||
                !decimal.TryParse(txtBuying.Text, out decimal buyingPrice) ||
                !decimal.TryParse(txtSellingPrice.Text, out decimal sellingPrice))
            {
                MessageBox.Show("Please enter valid numeric values for Quantity and Prices.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO medicines (Name, Type, StockQuantity, CostPerUnit, SellingPrice, ExpiryDate, BatchNumber) " +
               "VALUES (@medName, @category, @qty, @buyPrice, @sellPrice, @expiry, @batchNum)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Bind parameters perfectly to your real schema variables
                        cmd.Parameters.AddWithValue("@medName", txtMedicineName.Text.Trim());
                        cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem.ToString()); // Maps to 'Type'
                        cmd.Parameters.AddWithValue("@qty", quantity);                                 // Maps to 'StockQuantity'
                        cmd.Parameters.AddWithValue("@buyPrice", buyingPrice);                         // Maps to 'CostPerUnit'
                        cmd.Parameters.AddWithValue("@sellPrice", sellingPrice);                       // Maps to 'SellingPrice'
                        cmd.Parameters.AddWithValue("@expiry", dtpExpiryDate.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@batchNum", txtBatchNumber.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New medicine added successfully to inventory!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearAllFields();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Database Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        

        private void ClearAllFields()
        {
            txtMedicineName.Clear();
            txtBatchNumber.Clear();
            cmbCategory.SelectedIndex = -1;
            txtQuantity.Clear();
            txtBuying.Clear();
            txtSellingPrice.Clear();
            dtpExpiryDate.Value = DateTime.Now;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
    }

}
