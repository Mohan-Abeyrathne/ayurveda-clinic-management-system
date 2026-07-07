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
    public partial class StaffDashboard : Form
    {
        private bool isLoggingOut = false; // flag for login
        private Form activeForm = null;
        public StaffDashboard()
        {
            InitializeComponent();
        }

        private void StaffDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlMainContent.Controls.Add(childForm);
            pnlMainContent.Tag = childForm;

            childForm.BringToFront();

            childForm.Show();
        }

        private void btnMainDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new StaffHomeForm());
        }

        private void button2_Click(object sender, EventArgs e) // book appoinment btn
        {
            StaffManageAppoinment manageAppoinmentPopup = new StaffManageAppoinment();
            manageAppoinmentPopup.ShowDialog(this);
        }

        private void btnPatientManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnDoshaProfiler_Click(object sender, EventArgs e)
        {

        }

        private void btnHerbalStock_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                isLoggingOut = true;

                Form1 loginForm = (Form1)Application.OpenForms["Form1"];

                if (loginForm != null)
                {
                    loginForm.Show();

                    TextBox txtUser = (TextBox)loginForm.Controls.Find("login_username", true).FirstOrDefault();
                    TextBox txtPass = (TextBox)loginForm.Controls.Find("login_password", true).FirstOrDefault();
                    if (txtUser != null) txtUser.Clear();
                    if (txtPass != null) txtPass.Clear();
                }
                else
                {
                    Form1 newLoginForm = new Form1();
                    newLoginForm.Show();
                }

                this.Close();
            }
        }

        private void StaffDashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
