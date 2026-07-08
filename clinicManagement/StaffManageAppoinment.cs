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
    public partial class StaffManageAppoinment : Form
    {
        private bool isLoggingOut = false; // flag for login
        private Form activeForm = null;
        public StaffManageAppoinment()
        {
            InitializeComponent();
        }


        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            appoinmentrightpnlsubcontent.Controls.Clear();
            ucAddAppointment addAppointment = new ucAddAppointment();
            addAppointment.Dock = DockStyle.Fill;
            appoinmentrightpnlsubcontent.Controls.Add(addAppointment);
            addAppointment.BringToFront();


        }

        private void StaffManageAppoinment_Load(object sender, EventArgs e)
        {

        }

        private void appoinmentrightpnlsubcontent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditDeleteAppointment_Click(object sender, EventArgs e)
        {
            appoinmentrightpnlsubcontent.Controls.Clear();
            ucManageAppointment manageAppointment = new ucManageAppointment();
            manageAppointment.Dock = DockStyle.Fill;
            appoinmentrightpnlsubcontent.Controls.Add(manageAppointment);
            manageAppointment.BringToFront();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
