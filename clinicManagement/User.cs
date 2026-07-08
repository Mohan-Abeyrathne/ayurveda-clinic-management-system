using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinicManagement
{
    // Abstraction
    public abstract class User
    {
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }

        public User(string username, string fullName, string role)
        {
            Username = username;
            FullName = fullName;
            Role = role;
        }

        // POLYMORPHISM: Abstract template method that every subclass must implement uniquely
        public abstract void LaunchDashboard(Form loginForm);
    }


    // Inherited classes 
    public class Admin : User
    {
        public Admin(string username, string fullName) : base(username, fullName, "admin") { }

        public override void LaunchDashboard(Form loginForm)
        {
            MessageBox.Show($"Welcome, : {this.FullName}!", "Login Success");

            AdminDashboard adminPanel = new AdminDashboard();
            adminPanel.Show();
            loginForm.Hide();
        }
    }

    public class Doctor : User
    {
        public Doctor(string username, string fullName) : base(username, fullName, "doctor") { }

        public override void LaunchDashboard(Form loginForm)
        {
            MessageBox.Show($"Welcome, . {this.FullName}!", "Login Success");

            DoctorDashboard doctorPanel = new DoctorDashboard();
            doctorPanel.Show();
            loginForm.Hide();
        }
    }

    public class Staff : User
    {
        public Staff(string username, string fullName) : base(username, fullName, "staff") { }

        public override void LaunchDashboard(Form loginForm)
        {
            MessageBox.Show($"Welcome, Staff: {this.FullName}!", "Login Success");

            StaffDashboard staffPanel = new StaffDashboard();
            staffPanel.Show();
            loginForm.Hide();
        }
    }
}