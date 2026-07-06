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
using System.Drawing.Printing;
using System.Text;

namespace ClinicManagement
{
    public partial class PrescriptionForm : Form
    {
        DBConnection db = new DBConnection();
        public PrescriptionForm()
        {
            InitializeComponent();
            LoadMedicines();

        }


        private void LoadMedicines()
        {
            try
            {
                MySqlConnection con = db.GetConnection();

                con.Open();

                string query = "SELECT Name FROM medicines";

                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                cmbMedicine.Items.Clear();

                while (reader.Read())
                {
                    cmbMedicine.Items.Add(reader["Name"].ToString());
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtPatientID.Text == "")
            {
                MessageBox.Show("Please enter Patient ID.");
                return;
            }

            MySqlConnection con = db.GetConnection();

            try
            {
                con.Open();

                string query = "SELECT FullName FROM patients WHERE PatientID=@id";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", txtPatientID.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtPatientName.Text = reader["FullName"].ToString();
                }
                else
                {
                    MessageBox.Show("Patient not found.");
                    txtPatientName.Clear();
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvPrescription.Rows.Count == 0)
            {
                MessageBox.Show("No prescription available to print.");
                return;
            }

            StringBuilder prescription = new StringBuilder();

            prescription.AppendLine("=================================");
            prescription.AppendLine("       AYURVEDIC CLINIC");
            prescription.AppendLine("=================================");
            prescription.AppendLine("Patient ID   : " + txtPatientID.Text);
            prescription.AppendLine("Patient Name : " + txtPatientName.Text);
            prescription.AppendLine("Date         : " + DateTime.Now.ToShortDateString());
            prescription.AppendLine("");

            prescription.AppendLine("Medicines");
            prescription.AppendLine("---------------------------------");

            foreach (DataGridViewRow row in dgvPrescription.Rows)
            {
                if (row.IsNewRow)
                    continue;

                prescription.AppendLine("Medicine     : " + row.Cells[0].Value);
                prescription.AppendLine("Dosage       : " + row.Cells[1].Value);
                prescription.AppendLine("Frequency    : " + row.Cells[2].Value);
                prescription.AppendLine("Duration     : " + row.Cells[3].Value + " Days");
                prescription.AppendLine("Instructions : " + row.Cells[4].Value);
                prescription.AppendLine("---------------------------------");
            }

            prescription.AppendLine();
            prescription.AppendLine("Doctor ID : 1");
            prescription.AppendLine();
            prescription.AppendLine("Thank You!");
            prescription.AppendLine("Get Well Soon!");

            MessageBox.Show(prescription.ToString(),
                "Prescription Preview",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void PrescriptionForm_Load(object sender, EventArgs e)
        {

        }

        private void txtDiagnosis_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPatientID.Clear();
            txtPatientName.Clear();
            txtDiagnosis.Clear();

            cmbMedicine.SelectedIndex = -1;
            txtDosage.Clear();
            cmbFrequency.SelectedIndex = -1;
            numDuration.Value = 0;
            txtInstructions.Clear();

            dgvPrescription.Rows.Clear();
            txtPatientID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Do you want to save this prescription?",
            "Confirmation",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            if (txtPatientID.Text == "")
            {
                MessageBox.Show("Please search a patient first.");
                return;
            }

            if (dgvPrescription.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one medicine.");
                return;
            }

            try
            {
                MySqlConnection con = db.GetConnection();
                con.Open();

                // Save Prescription Header
                string query = @"INSERT INTO prescriptions
                        (PatientID, DoctorID, AppointmentID, Notes, ValidUntil)
                        VALUES
                        (@PatientID, @DoctorID, NULL, NULL, NULL)";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@PatientID", txtPatientID.Text);
                cmd.Parameters.AddWithValue("@DoctorID", 1);

                cmd.ExecuteNonQuery();

                // Get the newly inserted PrescriptionID
                int prescriptionID = (int)cmd.LastInsertedId;

                // Save each medicine
                foreach (DataGridViewRow row in dgvPrescription.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    // Find MedicineID from Medicine Name
                    string getMedicineQuery = "SELECT MedicineID FROM medicines WHERE Name=@Name";

                    MySqlCommand medicineCmd = new MySqlCommand(getMedicineQuery, con);
                    medicineCmd.Parameters.AddWithValue("@Name", row.Cells[0].Value.ToString());

                    int medicineID = Convert.ToInt32(medicineCmd.ExecuteScalar());

                    string detailQuery = @"INSERT INTO prescriptiondetails
                                  (PrescriptionID, MedicineID, Dosage, Frequency, Duration, SpecialInstructions)
                                  VALUES
                                  (@PrescriptionID,@MedicineID,@Dosage,@Frequency,@Duration,@Instructions)";

                    MySqlCommand detailCmd = new MySqlCommand(detailQuery, con);

                    detailCmd.Parameters.AddWithValue("@PrescriptionID", prescriptionID);
                    detailCmd.Parameters.AddWithValue("@MedicineID", medicineID);
                    detailCmd.Parameters.AddWithValue("@Dosage", row.Cells[1].Value.ToString());
                    detailCmd.Parameters.AddWithValue("@Frequency", row.Cells[2].Value.ToString());
                    detailCmd.Parameters.AddWithValue("@Duration", Convert.ToInt32(row.Cells[3].Value));
                    detailCmd.Parameters.AddWithValue("@Instructions", row.Cells[4].Value.ToString());

                    detailCmd.ExecuteNonQuery();
                    // Reduce medicine stock by 1
                    string updateStock = @"UPDATE medicines
                       SET StockQuantity = StockQuantity - 1
                       WHERE MedicineID = @MedicineID";

                    MySqlCommand stockCmd = new MySqlCommand(updateStock, con);
                    stockCmd.Parameters.AddWithValue("@MedicineID", medicineID);
                    stockCmd.ExecuteNonQuery();

                    // Check remaining stock
                    string stockQuery = "SELECT StockQuantity FROM medicines WHERE MedicineID=@MedicineID";

                    MySqlCommand checkCmd = new MySqlCommand(stockQuery, con);
                    checkCmd.Parameters.AddWithValue("@MedicineID", medicineID);

                    int stock = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (stock <= 20)
                    {
                        MessageBox.Show(
                            row.Cells[0].Value.ToString() + " is running low on stock!",
                            "Low Stock Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }

                con.Close();

                MessageBox.Show("Prescription Saved Successfully!");

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        { 
            if (cmbMedicine.Text == "")
            {
                MessageBox.Show("Please select a medicine.");
                return;
            }
            if (txtDosage.Text == "")

            {

                MessageBox.Show("Please enter dosage.");

                return;

            }

            if (cmbFrequency.Text == "")

            {

                MessageBox.Show("Please select frequency.");

                return;

            }

            if (numDuration.Value == 0)

            {
                MessageBox.Show("Please enter duration.");
                return;
            }
            
            if (txtInstructions.Text == "")
            {
                MessageBox.Show("Please enter special instructions.");
                txtInstructions.Focus();
                return;
            }

            // Check whether medicine is already added
            foreach (DataGridViewRow row in dgvPrescription.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (row.Cells[0].Value != null &&
                    row.Cells[0].Value.ToString() == cmbMedicine.Text)
                {
                    MessageBox.Show("This medicine has already been added.");
                    return;
                }
            }
           

            dgvPrescription.Rows.Add(
                cmbMedicine.Text,
                txtDosage.Text,
                cmbFrequency.Text,
                numDuration.Value,
                txtInstructions.Text
            );

            cmbMedicine.SelectedIndex = -1;
            txtDosage.Clear();
            cmbFrequency.SelectedIndex = -1;
            numDuration.Value = 0;
            txtInstructions.Clear();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvPrescription_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtPatientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPatientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
