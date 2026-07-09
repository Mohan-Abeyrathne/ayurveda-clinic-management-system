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
    public partial class UC_PharmacyDashboard : UserControl
    {
        private string connString = "server=127.0.0.1;user=root;password=;database=clinicmanagement";
        public UC_PharmacyDashboard()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UC_PharmacyDashboard_Load(object sender, EventArgs e)
        {
            RefreshDashboardData();
        }

        private void LoadDashboardMetrics()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            COUNT(*) as TotalItems,
                            SUM(CASE WHEN StockQuantity <= LowStockThreshold THEN 1 ELSE 0 END) as LowStockCount,
                            SUM(StockQuantity * CostPerUnit) as TotalValue
                        FROM medicines;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblTotalItemsCount.Text = reader["TotalItems"].ToString();

                            int lowStockCount = Convert.ToInt32(reader["LowStockCount"] == DBNull.Value ? 0 : reader["LowStockCount"]);
                            lblAlertCount.Text = lowStockCount.ToString();

                            decimal totalValue = Convert.ToDecimal(reader["TotalValue"] == DBNull.Value ? 0 : reader["TotalValue"]);
                            lblAssetValue.Text = string.Format("LKR {0:N2}", totalValue);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading metrics: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadLowStockGrid()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            Name AS 'Medicine Name', 
                            Type AS 'Type', 
                            StockQuantity AS 'Current Stock', 
                            LowStockThreshold AS 'Min Limit',
                            Manufacturer AS 'Manufacturer'
                        FROM medicines
                        WHERE StockQuantity <= LowStockThreshold;";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvLowStock.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading inventory grid: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void RefreshDashboardData()
        {
            LoadDashboardMetrics();
            LoadLowStockGrid();
        }

        private void dgvLowStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotalItemsCount_Click(object sender, EventArgs e)
        {

        }

        private void pnlTotalItemsCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAssetValueCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAlertCount_Click(object sender, EventArgs e)
        {

        }

        private void lblAlertTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblGridTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalItemsTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblAssetTitle_Click(object sender, EventArgs e)
        {

        }

        private void pnlAlertsCard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
