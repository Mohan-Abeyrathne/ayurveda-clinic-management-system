using AyurvedaClinicSystem.Database;
using AyurvedaClinicSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AyurvedaClinicSystem
{
    public partial class DiagnosisForm : Form
    {
        // Hidden variable to track which specific diagnosis row is currently selected by the doctor
        private int selectedDiagnosisID = 0;
        public DiagnosisForm()
        {
            InitializeComponent();
            LoadDiagnosisRecords();
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Field Validation
            if (string.IsNullOrWhiteSpace(txtPatientID.Text))
            {
                MessageBox.Show("Please search and load a valid Patient record first.", "Validation Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDiagnosis.Text))
            {
                MessageBox.Show("Please enter the final Diagnosis Result before saving.", "Validation Error");
                return;
            }
            // Create and Populate the OOP Model Object
            Diagnosis diagnosis = new Diagnosis();
            diagnosis.PatientID = Convert.ToInt32(txtPatientID.Text);
            diagnosis.Symptoms = txtSymptoms.Text.Trim();
            diagnosis.PulseDiagnosis = txtPulseDiagnosis.Text.Trim();
            diagnosis.DoctorNotes = txtDoctorNotes.Text.Trim();
            diagnosis.DiagnosisResult = txtDiagnosis.Text.Trim();
            diagnosis.RecordDate = DateTime.Now; // Generates the timestamp on the spot

            //Database Engine Communication Execution
            DBConnection db = new DBConnection();

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO diagnosis 
                            (PatientID, Symptoms, PulseDiagnosis, DoctorNotes, DiagnosisResult, DiagnosisDate) 
                            VALUES 
                            (@pid, @symptoms, @pulse, @notes, @result, @date)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@pid", diagnosis.PatientID);
                        cmd.Parameters.AddWithValue("@symptoms", diagnosis.Symptoms);
                        cmd.Parameters.AddWithValue("@pulse", diagnosis.PulseDiagnosis);
                        cmd.Parameters.AddWithValue("@notes", diagnosis.DoctorNotes);
                        cmd.Parameters.AddWithValue("@result", diagnosis.DiagnosisResult);
                        cmd.Parameters.AddWithValue("@date", diagnosis.RecordDate);

                        // Runs the insert operation on the MySQL server layout engine
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Diagnosis Saved Successfully!", "Success");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database write operation failed:\n" + ex.Message, "Database Execution Error");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtPatientID.Text == "")
            {
                MessageBox.Show("Enter Patient ID");
                return;
            }
            DBConnection db = new DBConnection();

            try
            {
                MySqlConnection conn = db.GetConnection();
                conn.Open();

                string query1 = "SELECT * FROM patients WHERE PatientID=@id";

                MySqlCommand cmd = new MySqlCommand(query1, conn);

                cmd.Parameters.AddWithValue("@id", txtPatientID.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtPatientName.Text = reader["FullName"].ToString();
                    txtBloodGroup.Text = reader["BloodType"].ToString();
                    txtDosha.Text = reader["DoshaType"].ToString();
                }
                else
                {
                    MessageBox.Show("Patient Not Found");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadDiagnosisRecords()
        {
            DBConnection db = new DBConnection();
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM diagnosis ORDER BY DiagnosisID DESC";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dgvDiagnosis.DataSource = dataTable;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to refresh diagnosis logs:\n" + ex.Message, "Data Grid Error");
            }
        }

        private void dgvDiagnosis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ensures the doctor clicked an actual data row, not the column header text area
            if (e.RowIndex >= 0)
            {
                // Extracts the complete data wrapper for the active highlighted row
                DataGridViewRow row = dgvDiagnosis.Rows[e.RowIndex];

                //Store the unique database ID of the selected row
                txtDiagnosisID.Text = row.Cells["DiagnosisID"].Value.ToString();

                // Maps data array row values back into your operational UI text boxes
                txtPatientID.Text = row.Cells["PatientID"].Value.ToString();
                txtSymptoms.Text = row.Cells["Symptoms"].Value.ToString();
                txtPulseDiagnosis.Text = row.Cells["PulseDiagnosis"].Value.ToString();
                txtDoctorNotes.Text = row.Cells["DoctorNotes"].Value.ToString();
                txtDiagnosis.Text = row.Cells["DiagnosisResult"].Value.ToString();

                btnSearch_Click(sender, e);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if the hidden ID box is empty
            if (string.IsNullOrWhiteSpace(txtDiagnosisID.Text))
            {
                MessageBox.Show("Please select a diagnosis record from the table below to edit first.", "Selection Required");
                return;
            }

            DBConnection db = new DBConnection();

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE diagnosis 
                            SET Symptoms = @symptoms, 
                                PulseDiagnosis = @pulse, 
                                DoctorNotes = @notes, 
                                DiagnosisResult = @result, 
                                DiagnosisDate = @date 
                            WHERE DiagnosisID = @did";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@symptoms", txtSymptoms.Text.Trim());
                        cmd.Parameters.AddWithValue("@pulse", txtPulseDiagnosis.Text.Trim());
                        cmd.Parameters.AddWithValue("@notes", txtDoctorNotes.Text.Trim());
                        cmd.Parameters.AddWithValue("@result", txtDiagnosis.Text.Trim());
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);

                        // Read the ID directly from the textbox text safely
                        cmd.Parameters.AddWithValue("@did", Convert.ToInt32(txtDiagnosisID.Text));

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Diagnosis Record Updated Successfully! 🔄", "Success");
                    conn.Close();

                    // Force reload the grid data
                    LoadDiagnosisRecords();

                    // Clear all textboxes
                    btnClear_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update database record:\n" + ex.Message, "Database Error");
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDiagnosisID.Clear(); // Clear the hidden ID box too!
            txtPatientID.Clear();
            txtPatientName.Clear();
            txtBloodGroup.Clear();
            txtDosha.Clear();
            txtSymptoms.Clear();
            txtPulseDiagnosis.Clear();
            txtDoctorNotes.Clear();
            txtDiagnosis.Clear();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Fix: Force assign the selected variable tracking parameter on the spot
            if (selectedDiagnosisID == 0 && dgvDiagnosis.CurrentRow != null)
            {
                selectedDiagnosisID = Convert.ToInt32(dgvDiagnosis.CurrentRow.Cells["DiagnosisID"].Value);
            }

            if (selectedDiagnosisID == 0)
            {
                MessageBox.Show("Please select a diagnosis record from the table below to delete.", "Selection Required");
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                "Are you absolutely sure you want to permanently delete this diagnosis file log record?",
                "Confirm Permanent Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
                DBConnection db = new DBConnection();

                try
                {
                    using (MySqlConnection conn = db.GetConnection())
                    {
                        conn.Open();

                        string query = "DELETE FROM diagnosis WHERE DiagnosisID = @did";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@did", selectedDiagnosisID);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Diagnosis File Deleted Successfully.", "Record Removed");
                        conn.Close();

                        LoadDiagnosisRecords();
                        btnClear_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to complete record deletion request:\n" + ex.Message, "Database Error");
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatientID.Text))
            {
                MessageBox.Show("Please select or search for a patient record first.", "Selection Required");
                return;
            }

            // Using a SaveFileDialog lets the doctor choose where to save the text report document file
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Documents (*.txt)|*.txt";
                sfd.FileName = $"MedicalReport_Patient_{txtPatientID.Text}.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Build a nicely formatted medical summary report layout string text block
                        string reportContent = $@"
============================================================
                AYURVEDA CLINIC MANAGEMENT SYSTEM           
                        MEDICAL REPORT                      
============================================================
Date Generated : {DateTime.Now:dd-MMM-yyyy HH:mm tt}
Patient ID     : {txtPatientID.Text}
Patient Name   : {txtPatientName.Text}
Blood Group    : {txtBloodGroup.Text}
Dosha Type     : {txtDosha.Text}
------------------------------------------------------------
CLINICAL EVALUATION DETAILED LOGS:
------------------------------------------------------------
Symptoms:
{txtSymptoms.Text}

Pulse Diagnosis:
{txtPulseDiagnosis.Text}

Doctor's Clinical Notes:
{txtDoctorNotes.Text}

Final Diagnosis Result:
{txtDiagnosis.Text}
------------------------------------------------------------
Issued By: (Nadi Pariksha Specialist)
============================================================
Note: This is an automatically generated electronic report file.";

                        // Physically write the entire generated text file block onto the local hard drive storage space
                        System.IO.File.WriteAllText(sfd.FileName, reportContent);
                        MessageBox.Show("Printable Medical Report Generated Successfully! 📄", "Success");

                        // Automatically open the file in Notepad so the doctor can print it immediately
                        System.Diagnostics.Process.Start("notepad.exe", sfd.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to save report file:\n" + ex.Message, "Export Error");
                    }

                }
            }
        }

        private void dgvDiagnosis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}





