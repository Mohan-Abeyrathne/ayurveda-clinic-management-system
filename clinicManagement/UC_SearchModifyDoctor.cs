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
    public partial class UC_SearchModifyDoctor : UserControl
    {
        private string connectionString = "Server=localhost;Database=ClinicManagement;Uid=root;Pwd=;";

        // Trackers for selected record keys
        private int selectedDoctorID = -1;
        private int selectedUserID = -1;

        public UC_SearchModifyDoctor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_SearchModifyDoctor_Load(object sender, EventArgs e)
        {
            LoadDoctorsList();
            ResetFormState();

        }

        private void LoadDoctorsList(string filterName = "")
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = @"SELECT d.DoctorID, d.UserID, u.UserName, d.FullName, d.Phone, d.Email, d.LicenseNumber, d.Specialization, d.Experience 
                                     FROM doctors d 
                                     INNER JOIN users u ON d.UserID = u.UserID";

                    if (!string.IsNullOrWhiteSpace(filterName))
                    {
                        query += " WHERE d.FullName LIKE @searchName";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(filterName))
                            cmd.Parameters.AddWithValue("@searchName", "%" + filterName + "%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvDoctorSearchList.DataSource = dt;

                        // Clean up UI display by hiding structural ID columns
                        if (dgvDoctorSearchList.Columns["DoctorID"] != null) dgvDoctorSearchList.Columns["DoctorID"].Visible = false;
                        if (dgvDoctorSearchList.Columns["UserID"] != null) dgvDoctorSearchList.Columns["UserID"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading registry: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtEditUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            LoadDoctorsList(txtSearchName.Text.Trim());

        }

        private void txtEditFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEditEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEditExperience_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDoctorSearchList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDoctorSearchList.Rows[e.RowIndex];

                selectedDoctorID = Convert.ToInt32(row.Cells["DoctorID"].Value);
                selectedUserID = Convert.ToInt32(row.Cells["UserID"].Value);

                txtEditFullName.Text = row.Cells["FullName"].Value.ToString();
                txtEditUsername.Text = row.Cells["UserName"].Value.ToString();
                txtEditPhone.Text = row.Cells["Phone"].Value.ToString();
                txtEditEmail.Text = row.Cells["Email"].Value.ToString();
                txtEditLicense.Text = row.Cells["LicenseNumber"].Value.ToString();
                txtEditSpecialization.Text = row.Cells["Specialization"].Value.ToString();
                txtEditExperience.Text = row.Cells["Experience"].Value.ToString();

                btnUpdateDoctor.Enabled = true;
                btnDeleteDoctor.Enabled = true;
            }
        }

        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {

            if (selectedUserID == -1 || selectedDoctorID == -1) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            string userUpdate = "UPDATE users SET UserName = @user, FullName = @name, ContactNumber = @phone WHERE UserID = @uid";
                            using (MySqlCommand cmdUser = new MySqlCommand(userUpdate, conn, trans))
                            {
                                cmdUser.Parameters.AddWithValue("@user", txtEditUsername.Text.Trim());
                                cmdUser.Parameters.AddWithValue("@name", txtEditFullName.Text.Trim());
                                cmdUser.Parameters.AddWithValue("@phone", txtEditPhone.Text.Trim());
                                cmdUser.Parameters.AddWithValue("@uid", selectedUserID);
                                cmdUser.ExecuteNonQuery();
                            }

                            string docUpdate = @"UPDATE doctors SET FullName = @name, Phone = @phone, Email = @email, 
                                                 LicenseNumber = @license, Specialization = @spec, Experience = @exp 
                                                 WHERE DoctorID = @did";
                            using (MySqlCommand cmdDoc = new MySqlCommand(docUpdate, conn, trans))
                            {
                                int expValue = 0;
                                int.TryParse(txtEditExperience.Text.Trim(), out expValue);

                                cmdDoc.Parameters.AddWithValue("@name", txtEditFullName.Text.Trim());
                                cmdDoc.Parameters.AddWithValue("@phone", txtEditPhone.Text.Trim());
                                cmdDoc.Parameters.AddWithValue("@email", txtEditEmail.Text.Trim());
                                cmdDoc.Parameters.AddWithValue("@license", txtEditLicense.Text.Trim());
                                cmdDoc.Parameters.AddWithValue("@spec", txtEditSpecialization.Text.Trim());
                                cmdDoc.Parameters.AddWithValue("@exp", expValue);
                                cmdDoc.Parameters.AddWithValue("@did", selectedDoctorID);
                                cmdDoc.ExecuteNonQuery();
                            }

                            trans.Commit();
                            MessageBox.Show("Doctor credentials updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ResetFormState();
                            LoadDoctorsList();
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            MessageBox.Show("Transaction failed. Changes discarded: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            if (selectedUserID == -1) return;

            DialogResult confirm = MessageBox.Show("Are you sure you want to permanently remove this doctor from the registry? All appointment mappings will be affected.",
                "Confirm Absolute Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        
                        string deleteQuery = "DELETE FROM users WHERE UserID = @uid";
                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@uid", selectedUserID);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Profile successfully purged from database files.", "Deleted Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetFormState();
                        LoadDoctorsList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Deletion Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ResetFormState()
        {
            txtEditUsername.Clear();
            txtEditFullName.Clear();
            txtEditPhone.Clear();
            txtEditEmail.Clear();
            txtEditLicense.Clear();
            txtEditSpecialization.Clear();
            txtEditExperience.Clear();

            btnUpdateDoctor.Enabled = false;
            btnDeleteDoctor.Enabled = false;
            selectedDoctorID = -1;
            selectedUserID = -1;
        }

        private void txtEditSpecialization_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
