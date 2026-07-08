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
    public partial class UC_ViewAllStaff : UserControl
    {
        private string connectionString = "Server=localhost;Database=ClinicManagement;Uid=root;Pwd=;";
        public UC_ViewAllStaff()
        {
            InitializeComponent();
        }

        private void UC_ViewAllStaff_Load(object sender, EventArgs e)
        {
            LoadStaffRegistryGrid();

        }

        private void LoadStaffRegistryGrid()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = @"SELECT UserName AS 'System Username', 
                                            FullName AS 'Staff Member Name', 
                                            ContactNumber AS 'Contact Number'
                                     FROM users 
                                     WHERE UserRole = 'staff'
                                     ORDER BY FullName ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvAllStaffRegistry.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to compile staff ledger: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
