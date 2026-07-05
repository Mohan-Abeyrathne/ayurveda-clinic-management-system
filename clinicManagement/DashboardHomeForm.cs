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
    public partial class DashboardHomeForm : Form
    {
        private string connectionString = "Server=localhost;Database=ClinicManagement;Uid=root;Pwd=;";
        public DashboardHomeForm()
        {
            InitializeComponent();
        }

        private void DashboardHomeForm_Load(object sender, EventArgs e)
        {
            LoadRealTimeCount();
        }

        private void LoadRealTimeCount()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Patients Count
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM patients", conn))
                        lblTotalPatientsCount.Text = cmd.ExecuteScalar().ToString();

                    // Doctors Count
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM doctors", conn))
                        lblTotalDoctorsCount.Text = cmd.ExecuteScalar().ToString();

                    // Staff Count
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM users WHERE UserRole = 'staff'", conn))
                        lblTotalStaffCount.Text = cmd.ExecuteScalar().ToString();

                    // Low Stock Medicine Count
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM medicines WHERE StockQuantity <= LowStockThreshold", conn))
                        lblLowStockCount.Text = cmd.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading metrics: " + ex.Message, "System Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void lblTotalDoctorsCount_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPatientsCount_Click(object sender, EventArgs e)
        {

        }


        private void btnBackToHome_Click_1(object sender, EventArgs e)
        {
            if (this.ParentForm is AdminDashboard mainDashboard)
            {
                this.Close();

            }
        }

        private void lblTotalStaffCount_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
