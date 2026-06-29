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
    public partial class AdminDashboard : Form
    {
        private bool isLoggingOut = false; // flag for login
        private Form activeForm = null;
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLoggingOut)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnInventory_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new DashboardHomeForm());

        }

        private void btnManageDoctors_Click(object sender, EventArgs e)
        {

        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }


}
