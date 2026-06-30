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
    public partial class UC_ViewAllDoctors : UserControl
    {
        private string connectionString = "Server=localhost;Database=ClinicManagement;Uid=root;Pwd=;";

        public UC_ViewAllDoctors()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_ViewAllDoctors_Load(object sender, EventArgs e)
        {
            LoadFullRegistryGrid();
        }

        private void LoadFullRegistryGrid()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = @"SELECT u.UserName AS 'System Username', 
                        d.FullName AS 'Doctor Name', 
                        d.Specialization AS 'Medical Department', 
                        d.Experience AS 'Years of Exp.',
                        d.Phone AS 'Contact Number', 
                        d.Email AS 'Email Address', 
                        d.LicenseNumber AS 'Medical License No.'
                 FROM doctors d 
                 INNER JOIN users u ON d.UserID = u.UserID
                 ORDER BY d.FullName ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvAllDoctorsRegistry.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to compile overview ledger: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvAllDoctorsRegistry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
