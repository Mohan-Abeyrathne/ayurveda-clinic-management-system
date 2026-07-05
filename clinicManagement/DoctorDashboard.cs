using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
