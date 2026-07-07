using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace clinicManagement
{
    // INHERITANCE - TherapyViewer inherits from Form
    public partial class TherapyViewer : Form
    {
        // ENCAPSULATION - private connection string
        private string connStr;

        public TherapyViewer()
        {
            InitializeComponent();

            // ENCAPSULATION - connection string set once
            connStr = ConfigurationManager
                .ConnectionStrings["ClinicDB"].ConnectionString;
        }

        private void TherapyViewer_Load(object sender, EventArgs e)
        {
            // ABSTRACTION - hides loading logic
            LoadPatients();
        }

        // ENCAPSULATION - private method hides DB logic
        private void LoadPatients()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string query = "SELECT PatientID, FullName FROM patients";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show(
                            "No patients found in the system.",
                            "No Data",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return;
                    }

                    cmbPatients.DataSource = dt;
                    cmbPatients.DisplayMember = "FullName";
                    cmbPatients.ValueMember = "PatientID";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Database error loading patients: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unexpected error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ENCAPSULATION - private method hides DB logic
        private string GetPatientDosha(int patientID)
        {
            string dosha = "";

            try
            {
                if (patientID <= 0)
                {
                    MessageBox.Show(
                        "Please select a valid patient.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return dosha;
                }

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string query = "SELECT DoshaType FROM patients " +
                                   "WHERE PatientID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", patientID);
                    conn.Open();

                    object result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show(
                            "No Dosha type found for this patient.",
                            "Not Found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return dosha;
                    }

                    dosha = result.ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Database error getting Dosha: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unexpected error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return dosha;
        }

        // ENCAPSULATION - private method hides DB logic
        private void LoadMatchingTherapies(string dosha)
        {
            try
            {
                if (string.IsNullOrEmpty(dosha))
                {
                    MessageBox.Show(
                        "Dosha type is empty. Cannot load therapies.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string query = @"SELECT 
                        TherapyName  AS Therapy,
                        Description  AS Description,
                        Duration     AS Duration
                        FROM therapies
                        WHERE SuitableDosha LIKE @dosha";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@dosha", "%" + dosha + "%");

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show(
                            "No therapies found for Dosha type: " + dosha,
                            "No Results",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return;
                    }

                    dgvTherapies.DataSource = dt;
                    dgvTherapies.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;
                    dgvTherapies.RowHeadersVisible = false;
                    dgvTherapies.AllowUserToAddRows = false;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Database error loading therapies: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unexpected error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // POLYMORPHISM - overriding Form's button click event
        private void btnViewTherapies_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPatients.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Please select a patient first.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                int patientID = (int)cmbPatients.SelectedValue;
                string dosha = GetPatientDosha(patientID);

                if (string.IsNullOrEmpty(dosha)) return;

                lblDoshaType.Text = "Dosha Type: " + dosha;
                LoadMatchingTherapies(dosha);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show(
                    "Invalid patient selection. Please try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unexpected error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void TherapyViewer_Load_1(object sender, EventArgs e)
        {

        }
    }
}