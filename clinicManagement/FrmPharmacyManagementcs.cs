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
    public partial class FrmPharmacyManagementcs : Form
    {
        private UC_PharmacyDashboard ucDashboard;
        private UC_ManageInventory ucInventory;
        private UC_AddNewMedicine ucAddMedicine;

        public FrmPharmacyManagementcs()
        {
            InitializeComponent();

            ucDashboard = new UC_PharmacyDashboard();
            ucInventory = new UC_ManageInventory();
            ucAddMedicine = new UC_AddNewMedicine();

            ShowUserControl(ucDashboard);
        }

        private void ShowUserControl(UserControl uc)
        {
            pnlContentStage.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContentStage.Controls.Add(uc);
        }

        private void FrmPharmacyManagementcs_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowUserControl(ucDashboard);

            ucDashboard.RefreshDashboardData();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ShowUserControl(ucInventory);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ShowUserControl(ucAddMedicine);
        }
    }
}
