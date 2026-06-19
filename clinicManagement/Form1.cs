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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = login_username.Text.Trim();
            String password = login_password.Text.Trim();

            // check usernames and passwords for the users login

            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("Login successful! Opening Admin Dashboard...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdminDashboard adminPanel = new AdminDashboard();

                adminPanel.Show();

                this.Hide();
            }
            else if(username == "staff" && password == "staff123")
            {
                MessageBox.Show("Login successful! Opening Staff Dashboard...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                StaffDashboard staffPanel = new StaffDashboard();

                staffPanel.Show();
                this.Hide();

            }
            else if(username == "doctor" && password == "doc123")
            {
                MessageBox.Show("Login successful! Opening Doctor Dashboard...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DoctorDashboard doctorPanel = new DoctorDashboard();

                doctorPanel.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                login_password.Clear();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            login_password.UseSystemPasswordChar = !login_showPass.Checked;
        }
    }
}
