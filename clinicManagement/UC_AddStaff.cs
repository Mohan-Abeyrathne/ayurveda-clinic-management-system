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
    public partial class UC_AddStaff : UserControl
    {
        private string connectionString = "Server=localhost;Database=ClinicManagement;Uid=root;Pwd=;";
        public UC_AddStaff()
        {
            InitializeComponent();
        }

        private void btnSaveStaff_Click(object sender, EventArgs e)
        {
            // validation checks
            if (string.IsNullOrWhiteSpace(txtStaffUsername.Text) ||
                string.IsNullOrWhiteSpace(txtStaffPassword.Text) ||
                string.IsNullOrWhiteSpace(txtStaffFullName.Text))
            {
                MessageBox.Show("Username, Password, and Full Name are strictly required to create a staff account.",
                                "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Database Insert
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"INSERT INTO users (UserName, Password, FullName, UserRole, ContactNumber) 
                                     VALUES (@user, @pass, @name, 'staff', @phone)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", txtStaffUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txtStaffPassword.Text.Trim()); 
                        cmd.Parameters.AddWithValue("@name", txtStaffFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtStaffPhone.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Staff account successfully registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save record to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UC_AddStaff_Load(object sender, EventArgs e)
        {

        }

        private void btnClearStaffFields_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtStaffUsername.Clear();
            txtStaffPassword.Clear();
            txtStaffFullName.Clear();
            txtStaffPhone.Clear();
        }
    }
}
