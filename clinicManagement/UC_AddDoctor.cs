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
    public partial class UC_AddDoctor : UserControl
    {
        private string connectionString = "Server=localhost;Database=ClinicManagement;Uid=root;Pwd=;";
        public UC_AddDoctor()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_AddDoctor_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveDoctor_Click(object sender, EventArgs e)
        {
        
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtLicense.Text))
            {
                MessageBox.Show("Username, Password, Full Name, and License Number are strictly required.",
                                "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Using a Transaction ensures if either table insertion fails, everything rolls back safely
                    using (MySqlTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            //Insert into users table
                            string userQuery = @"INSERT INTO users (UserName, Password, FullName, UserRole, ContactNumber) 
                                                 VALUES (@user, @pass, @name, 'doctor', @phone);
                                                 SELECT LAST_INSERT_ID();";

                            long newUserID = 0;

                            using (MySqlCommand cmdUser = new MySqlCommand(userQuery, conn, trans))
                            {
                                cmdUser.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                                cmdUser.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                                cmdUser.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
                                cmdUser.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());

                                newUserID = Convert.ToInt64(cmdUser.ExecuteScalar());
                            }

                            //Insert into doctors table
                            string docQuery = @"INSERT INTO doctors (UserID, FullName, Phone, Email, LicenseNumber, Specialization, Experience) 
                                                VALUES (@uid, @name, @phone, @email, @license, @spec, @exp)";

                            using (MySqlCommand cmdDoc = new MySqlCommand(docQuery, conn, trans))
                            {
                                int experienceValue = 0;
                                int.TryParse(txtExperience.Text.Trim(), out experienceValue);

                                cmdDoc.Parameters.AddWithValue("@uid", newUserID);
                                cmdDoc.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
                                cmdDoc.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                                cmdDoc.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                                cmdDoc.Parameters.AddWithValue("@license", txtLicense.Text.Trim());
                                cmdDoc.Parameters.AddWithValue("@spec", txtSpecialization.Text.Trim());
                                cmdDoc.Parameters.AddWithValue("@exp", experienceValue);

                                cmdDoc.ExecuteNonQuery();
                            }

                            // Commit transaction to database
                            trans.Commit();

                            MessageBox.Show("Doctor profile successfully added to the database registry!",
                                            "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearInputs();
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            MessageBox.Show("Transaction aborted. Failed to save: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to connect to database: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtLicense.Clear();
            txtSpecialization.Clear();
            txtExperience.Clear();
        }
    }
}
