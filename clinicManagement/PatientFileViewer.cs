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
    public partial class PatientFileViewer : Form
    {
        public PatientFileViewer()
        {
            InitializeComponent();
        }

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DisplayInfo(string info) //Polymorphism
        {
            MessageBox.Show(info);
        }
        private void DisplayInfo(string info, string title) //Method Overload - Polymorphism
        {
            MessageBox.Show(info, title);
        }

        private void LoadPatients(string PatientId = "") //avoids duplication
        {
            string connectionString = "server=localhost;port=3306;database=clinicmanagement;uid=root;pwd=;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT PatientID, FullName, DateOfBirth, Gender, Phone, Email, BloodType, DoshaType, Allergies FROM patients";
                    if(!string.IsNullOrWhiteSpace(PatientId))
                    {
                        query += " WHERE PatientID = @id";
                    }
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrWhiteSpace(PatientId))
                    {
                        cmd.Parameters.AddWithValue("@id", PatientId);
                    }
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPatients.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                DisplayInfo(ex.Message, "Database Error"); //Polymorphism
            }
        }

        private void PatientFileViewer_Load(object sender, EventArgs e)
        {
            LoadPatients(); //abstraction
            CenterAllControls();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            if(dgvPatients.SelectedRows.Count > 0)
            {
                int patientID = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells["PatientID"].Value);

                PatientProfileForm profile = new PatientProfileForm();
                profile.patientId = patientID;
                profile.ShowDialog();
            }
            else
            {
                DisplayInfo("Please select a patient to move forward!", "Validation"); //Polymorphism
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                DisplayInfo("Please enter the patient ID!");
                return;
            }

            try
            {
                LoadPatients(txtSearch.Text.Trim());
                if(dgvPatients.Rows.Count == 0)
                {
                    DisplayInfo("No patient found with the given patient ID!","Search Result"); //Polymorphism
                }
            }
            catch (Exception ex)
            {
                DisplayInfo(ex.Message, "Search Error"); //Polymorphism
            }
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.ForeColor = Color.DarkGreen;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.ForeColor = Color.Honeydew;
        }

        private void btnViewProfile_MouseEnter(object sender, EventArgs e)
        {
            btnViewProfile.ForeColor = Color.DarkGreen;
        }

        private void btnViewProfile_MouseLeave(object sender, EventArgs e)
        {
            btnViewProfile.ForeColor = Color.Honeydew;
        }

        private void btnClose1_MouseEnter(object sender, EventArgs e)
        {
            btnClose1.ForeColor = Color.DarkGreen;
        }

        private void btnClose1_MouseLeave(object sender, EventArgs e)
        {
            btnClose1.ForeColor = Color.Honeydew;
        }

        //aligning the content to the center of the page
        private void CenterAllControls()
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;

            int searchGap = 12;
            int searchGroupWidth = txtSearch.Width + searchGap + btnSearch.Width;
            int searchStartX = (this.ClientSize.Width - searchGroupWidth) / 2;
            txtSearch.Left = searchStartX;
            btnSearch.Left = txtSearch.Right + searchGap;

            dgvPatients.Left = (this.ClientSize.Width - dgvPatients.Width) / 2;

            int btnGap = 30;
            int btnGroupWidth = btnViewProfile.Width + btnGap + btnClose1.Width;
            int btnStartX = (this.ClientSize.Width - btnGroupWidth) / 2;
            btnViewProfile.Left = btnStartX;
            btnClose1.Left = btnViewProfile.Right + btnGap;
        }

        private void PatientFileViewer_Resize(object sender, EventArgs e)
        {
            CenterAllControls();
        }
    }
}
