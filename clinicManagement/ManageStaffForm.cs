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
    public partial class ManageStaffForm : Form
    {
        public ManageStaffForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panelLeftStaff_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearchStaffView_Click(object sender, EventArgs e)
        {
            panelRightStaff.Controls.Clear();
            UC_SearchModifyStaff searchStaffView = new UC_SearchModifyStaff();
            searchStaffView.Dock = DockStyle.Fill;
            panelRightStaff.Controls.Add(searchStaffView);
            searchStaffView.BringToFront();
        }

        private void btnViewAllStaffView_Click(object sender, EventArgs e)
        {
            panelRightStaff.Controls.Clear();
            UC_ViewAllStaff viewAllStaffGrid = new UC_ViewAllStaff();
            viewAllStaffGrid.Dock = DockStyle.Fill;
            panelRightStaff.Controls.Add(viewAllStaffGrid);
            viewAllStaffGrid.BringToFront();
        }

        private void btnCancelStaff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStaffView_Click(object sender, EventArgs e)
        {
            panelRightStaff.Controls.Clear();
            UC_AddStaff addStaffView = new UC_AddStaff();
            addStaffView.Dock = DockStyle.Fill;
            panelRightStaff.Controls.Add(addStaffView);
            addStaffView.BringToFront();
        }

        private void panelRightStaff_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
