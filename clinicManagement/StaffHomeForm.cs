using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Remember to install the MySql.Data NuGet package

namespace clinicManagement
{
    public partial class StaffHomeForm : Form
    {
        // Update connection details if your XAMPP/MySQL credentials are different
        private string connectionString = "server=localhost;database=clinicmanagement;uid=root;pwd=;";

        public StaffHomeForm()
        {
            InitializeComponent();
        }

        private void StaffHomeForm_Load(object sender, EventArgs e)
        {
            // This triggers the data fetch immediately when the panel loads
            LoadDashboardMetrics();
        }

        private void LoadDashboardMetrics()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string queryRemaining = "SELECT COUNT(*) FROM appointments WHERE AppointmentDate = CURDATE() AND Status = 'Scheduled'";
                    using (MySqlCommand cmd = new MySqlCommand(queryRemaining, conn))
                    {
                        int remainingCount = Convert.ToInt32(cmd.ExecuteScalar());
                        lblRemainingCount.Text = remainingCount.ToString();
                    }

                    string queryCompleted = "SELECT COUNT(*) FROM appointments WHERE AppointmentDate = CURDATE() AND Status = 'Completed'";
                    using (MySqlCommand cmd = new MySqlCommand(queryCompleted, conn))
                    {
                        int completedCount = Convert.ToInt32(cmd.ExecuteScalar());
                        lblCompletedCount.Text = completedCount.ToString();
                    }

                    string queryNewPatients = "SELECT COUNT(*) FROM patients WHERE DATE(RegisteredDate) = CURDATE()";
                    using (MySqlCommand cmd = new MySqlCommand(queryNewPatients, conn))
                    {
                        int newPatientsCount = Convert.ToInt32(cmd.ExecuteScalar());
                        lblNewPatientsCount.Text = newPatientsCount.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading statistics: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is StaffDashboard mainDashboard)
            {
                this.Close();
            }
        }

        private void lblRemainingCount_Click(object sender, EventArgs e) { }
        private void lblNewPatientsCount_Click(object sender, EventArgs e) { }
        private void lblCompletedCount_Click(object sender, EventArgs e) { }
    }
}