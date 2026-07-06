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
    public partial class UC_SearchModifyStaff : UserControl
    {
        private string connectionString = "Server=localhost;Database=ClinicManagement;Uid=root;Pwd=;";
        private int selectedUserID = -1;

        public UC_SearchModifyStaff()
        {
            InitializeComponent();
        }


        private void txtSearchStaffName_TextChanged(object sender, EventArgs e)
        {
            LoadStaffList(txtSearchStaffName.Text.Trim());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtEditStaffFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_SearchModifyStaff_Load(object sender, EventArgs e)
        {
            LoadStaffList();
            ResetFormState();

        }

        private void LoadStaffList(string filterName = "")
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Filter for 'staff' role
                    string query = @"SELECT UserID, UserName, FullName, ContactNumber 
                                     FROM users 
                                     WHERE UserRole = 'staff'";

                    if (!string.IsNullOrWhiteSpace(filterName))
                    {
                        query += " AND FullName LIKE @searchName";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(filterName))
                            cmd.Parameters.AddWithValue("@searchName", "%" + filterName + "%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvStaffSearchList.DataSource = dt;

                        // Hide primary key ID column
                        if (dgvStaffSearchList.Columns["UserID"] != null)
                            dgvStaffSearchList.Columns["UserID"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading staff ledger: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvStaffSearchList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStaffSearchList.Rows[e.RowIndex];

                selectedUserID = Convert.ToInt32(row.Cells["UserID"].Value);

                txtEditStaffUsername.Text = row.Cells["UserName"].Value.ToString();
                txtEditStaffFullName.Text = row.Cells["FullName"].Value.ToString();
                txtEditStaffPhone.Text = row.Cells["ContactNumber"].Value.ToString();

                btnUpdateStaff.Enabled = true;
                btnDeleteStaff.Enabled = true;
            }

        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            if (selectedUserID == -1) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE users SET UserName = @user, FullName = @name, ContactNumber = @phone WHERE UserID = @uid";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", txtEditStaffUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@name", txtEditStaffFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtEditStaffPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@uid", selectedUserID);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Staff profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetFormState();
                    LoadStaffList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to modify staff data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (selectedUserID == -1) return;

            DialogResult confirm = MessageBox.Show("Are you sure you want to permanently remove this staff account?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM users WHERE UserID = @uid";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@uid", selectedUserID);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Staff account successfully removed.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetFormState();
                        LoadStaffList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to delete account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ResetFormState()
        {
            txtEditStaffUsername.Clear();
            txtEditStaffFullName.Clear();
            txtEditStaffPhone.Clear();

            btnUpdateStaff.Enabled = false;
            btnDeleteStaff.Enabled = false;
            selectedUserID = -1;
        }

        private void txtEditStaffPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
