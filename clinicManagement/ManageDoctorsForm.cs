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
    public partial class ManageDoctorsForm : Form
    {
        public ManageDoctorsForm()
        {
            InitializeComponent();
        }

        private void ManageDoctorsForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddDoctorView_Click(object sender, EventArgs e)
        {
            panelRight.Controls.Clear();

            UC_AddDoctor addDocView = new UC_AddDoctor();

            addDocView.Dock = DockStyle.Fill;

            panelRight.Controls.Add(addDocView);
            addDocView.BringToFront();

        }

        private void btnSearchView_Click(object sender, EventArgs e)
        {
            panelRight.Controls.Clear();
            UC_SearchModifyDoctor searchView = new UC_SearchModifyDoctor();
            searchView.Dock = DockStyle.Fill;
            panelRight.Controls.Add(searchView);
            searchView.BringToFront();

        }

        private void btnViewAllView_Click(object sender, EventArgs e)
        {
            panelRight.Controls.Clear();
            UC_ViewAllDoctors viewAllGrid = new UC_ViewAllDoctors();
            viewAllGrid.Dock = DockStyle.Fill;
            panelRight.Controls.Add(viewAllGrid);
            viewAllGrid.BringToFront();
        }
    }
}
