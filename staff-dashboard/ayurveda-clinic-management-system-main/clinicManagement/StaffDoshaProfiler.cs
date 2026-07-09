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
using System.Data;

namespace clinicManagement
{
    public partial class StaffDoshaProfiler : Form
    {
        private string connectionString =
    "server=localhost;database=clinicmanagement;uid=root;pwd=;";
        public StaffDoshaProfiler()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void StaffDoshaProfiler_Load(object sender, EventArgs e)
        {
            LoadPatients();

        }
        private void LoadPatients()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT PatientID, FullName FROM patients";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    cmbPatient.DataSource = dt;
                    cmbPatient.DisplayMember = "FullName";
                    cmbPatient.ValueMember = "PatientID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void grpPatientDetails_Enter(object sender, EventArgs e)
        {

        }

        private void btnLoadPatient_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadPatient_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM patients WHERE PatientID=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", cmbPatient.SelectedValue);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblPatientIDDValue.Text = reader["PatientID"].ToString();
                    lblPatientNameValue.Text = reader["FullName"].ToString();

                    DateTime dob = Convert.ToDateTime(reader["DateOfBirth"]);

                    int age = DateTime.Now.Year - dob.Year;
                    if (dob > DateTime.Now.AddYears(-age))
                        age--;

                 
                    lblPatientAgeValue.Text = age.ToString();
                    lblPatientGenderValue.Text = reader["Gender"].ToString();
                    lblPatientBloodValue.Text = reader["BloodType"].ToString();
                    lblCurrentDoshaValue.Text = reader["DoshaType"].ToString();
                }

                reader.Close();
            }
        }

        private void lblPatientID_Click(object sender, EventArgs e)
        {

        }
    }
}
