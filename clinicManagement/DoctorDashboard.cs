using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagement;

namespace clinicManagement
{
    public partial class DoctorDashboard : Form
    {
        public DoctorDashboard()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void DoctorDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DoctorDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnPatientFiles_Click(object sender, EventArgs e)
        {
            PatientFileViewer viewer = new PatientFileViewer();
            viewer.Show();
        }

        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            DiagnosisForm diagnosisWindow = new DiagnosisForm();

            // 2. Display the form model on screen instantly 
            diagnosisWindow.Show();
        }

        private void btnPatientFiles_MouseEnter(object sender, EventArgs e)
        {
            btnPatientFiles.ForeColor = Color.DarkGreen;
        }

        private void btnPatientFiles_MouseLeave(object sender, EventArgs e)
        {
            btnPatientFiles.ForeColor = Color.Honeydew;
        }

        private void btnDiagnosis_MouseEnter(object sender, EventArgs e)
        {
            btnDiagnosis.ForeColor = Color.DarkGreen;
        }

        private void btnDiagnosis_MouseLeave(object sender, EventArgs e)
        {
            btnDiagnosis.ForeColor = Color.Honeydew;
        }

        private void btnPrescription_MouseEnter(object sender, EventArgs e)
        {
            btnPrescription.ForeColor = Color.DarkGreen;
        }

        private void btnPrescription_MouseLeave(object sender, EventArgs e)
        {
            btnPrescription.ForeColor = Color.Honeydew;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.DarkGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Honeydew;

        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            btnLogOut.ForeColor = Color.DarkGreen;
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.ForeColor = Color.Honeydew;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            PrescriptionForm PrescriptionWindow = new PrescriptionForm();

            PrescriptionWindow.Show();
        }
    }
}
