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

        public class DoshaQuestion
        {
            public int QuestionID { get; set; }
            public string QuestionText { get; set; }
            public string VataOption { get; set; }
            public string PittaOption { get; set; }
            public string KaphaOption { get; set; }
        }

        private List<DoshaQuestion> questions = new List<DoshaQuestion>();

        private int currentQuestion = 0;

        private string[] selectedAnswers = new string[10];

        private int vataScore = 0;
        private int pittaScore = 0;
        private int kaphaScore = 0;
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

            LoadQuestions();

            btnPrevious.Enabled = false;

            btnFinish.Visible = false;

        }

        private void LoadQuestions()
        {
            questions.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM doshaquestions ORDER BY QuestionID";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DoshaQuestion q = new DoshaQuestion();

                    q.QuestionID = Convert.ToInt32(reader["QuestionID"]);
                    q.QuestionText = reader["QuestionText"].ToString();
                    q.VataOption = reader["VataOption"].ToString();
                    q.PittaOption = reader["PittaOption"].ToString();
                    q.KaphaOption = reader["KaphaOption"].ToString();

                    questions.Add(q);
                }

                reader.Close();
            }

            if (questions.Count > 0)
            {
                ShowQuestion();
            }
        }

        private void ShowQuestion()
        {
            lblQuestionNo.Text = "Question " + (currentQuestion + 1) + " of " + questions.Count;

            lblQuestion.Text = questions[currentQuestion].QuestionText;

            rbOption1.Text = questions[currentQuestion].VataOption;
            rbOption2.Text = questions[currentQuestion].PittaOption;
            rbOption3.Text = questions[currentQuestion].KaphaOption;

            rbOption1.Checked = false;
            rbOption2.Checked = false;
            rbOption3.Checked = false;

            if (selectedAnswers[currentQuestion] == rbOption1.Text)
                rbOption1.Checked = true;
            else if (selectedAnswers[currentQuestion] == rbOption2.Text)
                rbOption2.Checked = true;
            else if (selectedAnswers[currentQuestion] == rbOption3.Text)
                rbOption3.Checked = true;

            btnPrevious.Enabled = currentQuestion > 0;
            btnNext.Visible = currentQuestion < questions.Count - 1;
            btnFinish.Visible = currentQuestion == questions.Count - 1;

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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbOption1.Checked)
                selectedAnswers[currentQuestion] = rbOption1.Text;
            else if (rbOption2.Checked)
                selectedAnswers[currentQuestion] = rbOption2.Text;
            else if (rbOption3.Checked)
                selectedAnswers[currentQuestion] = rbOption3.Text;
            else
            {
                MessageBox.Show("Please select an answer before continuing.");
                return;
            }

            if (currentQuestion < questions.Count - 1)
            {
                currentQuestion++;
                ShowQuestion();
            }

            btnPrevious.Enabled = currentQuestion > 0;
            btnNext.Visible = currentQuestion < questions.Count - 1;
            btnFinish.Visible = currentQuestion == questions.Count - 1;

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentQuestion > 0)
            {
                currentQuestion--;
                ShowQuestion();
            }

            btnPrevious.Enabled = currentQuestion > 0;
            btnNext.Visible = true;
            btnFinish.Visible = false;
        }
    }
}
