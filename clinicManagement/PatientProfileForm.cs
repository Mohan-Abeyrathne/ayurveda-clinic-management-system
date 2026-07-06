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
using System.IO;
using System.Diagnostics;

namespace clinicManagement
{
    public partial class PatientProfileForm : Form //inheritance
    {
        private int PatientId;
        public int patientId
        {
            get { return PatientId; }
            set { PatientId = value; } //encapsulation --> used in PatientFileViewer.cs in line 68
        }
        private string connectionString = "server=localhost;port=3306;database=clinicmanagement;uid=root;pwd=;";
        public PatientProfileForm()
        {
            InitializeComponent();
            this.Resize += PatientProfileForm_Resize;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void grpPrescriptions_Enter(object sender, EventArgs e)
        {

        }
        private void LoadDosha() //encapsulation
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM doshaprofiles WHERE PatientID = @id ORDER BY AnalysisDate DESC LIMIT 1";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", PatientId);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblDoshaValue.Text = reader["DominantDosha"].ToString();
                        lblAssessmentDateValue.Text = Convert.ToDateTime(reader["AnalysisDate"]).ToShortDateString();
                    }
                    else
                    {
                        lblDoshaValue.Text = "Not Available!";
                        lblAssessmentDateValue.Text = "-";
                    }
                    reader.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading dosha!" + ex.Message);
            }
        }

        private void LoadHistory() //encapsulation
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            AppointmentID,
                            AppointmentDate,
                            TimeSlot,
                            Status,
                            Notes,
                            CancelReason
                        FROM appointments
                        WHERE PatientID = @id
                        ORDER BY AppointmentDate DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", PatientId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvHistory.DataSource = dt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading history!" + ex.Message);
            }
        }

        private void LoadPrescriptions() //Encapsulation
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                    SELECT
                        PrescriptionID,
                        PrescriptionDate,
                        Notes,
                        ValidUntil
                    FROM prescriptions
                    WHERE PatientID = @id
                    ORDER BY PrescriptionDate DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", PatientId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPrescriptions.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading prescriptions!" + ex.Message);
            }
        }

        private void LoadTherapySessions() //Encapsulation
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                    SELECT
                        TreatmentID,
                        TreatmentType,
                        ScheduledDate,
                        ScheduledTime,
                        DurationMinutes,
                        Status,
                        Room
                    FROM treatments
                    WHERE PatientID = @id
                    ORDER BY ScheduledDate DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", PatientId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTherapy.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading therapy history!" + ex.Message);
            }
        }
        private void PatientProfileForm_Load(object sender, EventArgs e) 
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM patients WHERE PatientID=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", PatientId);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblNameValue.Text = reader["FullName"].ToString();

                        DateTime dob = Convert.ToDateTime(reader["DateOfBirth"]);
                        int age = DateTime.Now.Year - dob.Year;
                        if (DateTime.Now < dob.AddYears(age)) age--;

                        lblAgeValue.Text = age.ToString();
                        lblGenderValue.Text = reader["Gender"].ToString();
                        lblBloodValue.Text = reader["BloodType"].ToString();
                        lblPhoneValue.Text = reader["Phone"].ToString();
                        lblAddressValue.Text = reader["Address"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patient information!" + ex.Message);
            }
            LoadDosha(); //abstraction as the method is coded before
            LoadHistory(); //abstraction as the method is coded before
            LoadPrescriptions(); //abstraction as the method is coded before
            LoadTherapySessions(); //abstraction as the method is coded before

            CenterAllControls();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder report = new StringBuilder();
                report.AppendLine("======================================");
                report.AppendLine("        PATIENT MEDICAL REPORT");
                report.AppendLine("======================================");
                report.AppendLine();

                report.AppendLine("Patient Name: " + lblNameValue.Text);
                report.AppendLine("Age: " + lblAgeValue.Text);
                report.AppendLine("Gender: " + lblGenderValue.Text);
                report.AppendLine("Blood Group: " + lblBloodValue.Text);
                report.AppendLine("Phone: " + lblPhoneValue.Text);
                report.AppendLine("Address: " + lblAddressValue.Text);
                report.AppendLine();

                report.AppendLine("Dosha Type: " + lblDoshaValue.Text);
                report.AppendLine("Assessment Date: " + lblAssessmentDateValue.Text);
                report.AppendLine();

                report.AppendLine("Medical History");
                report.AppendLine("---------------------------------------");

                foreach (DataGridViewRow row in dgvHistory.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            report.Append(cell.Value + "  ");
                        }
                        report.AppendLine();
                    }
                }
                report.AppendLine();
                report.AppendLine("Previous Prescriptions");
                report.AppendLine("---------------------------------------");

                foreach (DataGridViewRow row in dgvPrescriptions.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            report.Append(cell.Value + "  ");
                        }
                        report.AppendLine();
                    }
                }
                report.AppendLine();
                report.AppendLine("Therapy Sessions");
                report.AppendLine("---------------------------------------");

                foreach (DataGridViewRow row in dgvTherapy.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            report.Append(cell.Value + "  ");
                        }
                    }
                    report.AppendLine();
                }
                string filePath = Path.Combine(Application.StartupPath, "PatientReport.txt");
                File.WriteAllText(filePath, report.ToString());
                Process.Start("notepad.exe", filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to generate report!\n" + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CenterAllControls()
        {
            int spacing = 40;
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;

            int totalWidth = grpPersonal.Width + spacing + grpDosha.Width;

            int startX = (this.ClientSize.Width - totalWidth) / 2;
            grpPersonal.Left = startX;
            grpDosha.Left = grpPersonal.Right + spacing;
            grpHistory.Left = (this.ClientSize.Width - grpHistory.Width) / 2;
            grpPrescriptions.Left = (this.ClientSize.Width - grpPrescriptions.Width) / 2;
            groupBox1.Left = (this.ClientSize.Width - groupBox1.Width) / 2;

            int buttonSpacing = 20;
            int buttonsWidth = btnPrint.Width + btnClose.Width + buttonSpacing;
            int buttonsStart = (this.ClientSize.Width - buttonsWidth) / 2;

            int totalButtonWidth = btnPrint.Width + btnClose.Width + buttonSpacing;
            btnPrint.Left = buttonsStart;
            btnClose.Left = btnPrint.Right + buttonSpacing;
        }
        private void PatientProfileForm_Resize(object sender, EventArgs e)
        {
            CenterAllControls();
        }

        private void btnPrint_MouseEnter(object sender, EventArgs e)
        {
            btnPrint.ForeColor = Color.DarkGreen;
        }

        private void btnPrint_MouseLeave(object sender, EventArgs e)
        {
            btnPrint.ForeColor = Color.Honeydew;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.DarkGreen;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Honeydew;
        }
    }
}
