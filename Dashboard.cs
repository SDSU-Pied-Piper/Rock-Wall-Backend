using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDSU_Rock_Wall_CRM
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void addUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var dashboardForm = new BasicLayout();
            dashboardForm.Location = this.Location;
            dashboardForm.StartPosition = this.StartPosition;
            dashboardForm.WindowState = FormWindowState.Normal;
            dashboardForm.titleOfDataLabel.Text = "Add User";
            dashboardForm.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var dashBoard = new Dashboard();
            dashBoard.Location = this.Location;
            dashBoard.StartPosition = this.StartPosition;
            dashBoard.WindowState = FormWindowState.Normal;
            var todayTotalUserInsightPrefix = "Today's Patrons: ";
            var dateOfToday = DateTime.Today;

            dashBoard.Show();
            this.Hide();
        }

        private void editUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var dashboardForm = new BasicLayout();
            dashboardForm.Location = this.Location;
            dashboardForm.StartPosition = this.StartPosition;
            dashboardForm.WindowState = FormWindowState.Normal;
            dashboardForm.titleOfDataLabel.Text = "Edit User";
            dashboardForm.Show();
            this.Hide();
        }

        private void deleteUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var dashboardForm = new BasicLayout();
            dashboardForm.Location = this.Location;
            dashboardForm.StartPosition = this.StartPosition;
            dashboardForm.WindowState = FormWindowState.Normal;
            dashboardForm.titleOfDataLabel.Text = "Delete User";
            dashboardForm.Show();
            this.Hide();
        }

        private void viewPendingSuspensionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var dashboardForm = new BasicLayout();
            dashboardForm.Location = this.Location;
            dashboardForm.StartPosition = this.StartPosition;
            dashboardForm.WindowState = FormWindowState.Normal;
            dashboardForm.titleOfDataLabel.Text = "Pending Suspensions";
            dashboardForm.Show();
            this.Hide();
        }
        private void suspendUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var dashboardForm = new BasicLayout();
            dashboardForm.Location = this.Location;
            dashboardForm.StartPosition = this.StartPosition;
            dashboardForm.WindowState = FormWindowState.Normal;
            dashboardForm.titleOfDataLabel.Text = "Suspend User";
            dashboardForm.Show();
            this.Hide();
        }

        private void addItemToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var dashboardForm = new BasicLayout();
            dashboardForm.Location = this.Location;
            dashboardForm.StartPosition = this.StartPosition;
            dashboardForm.WindowState = FormWindowState.Normal;
            dashboardForm.titleOfDataLabel.Text = "Add Inventory Item";
            dashboardForm.Show();
            this.Hide();
        }

        private void editItemToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var dashboardForm = new BasicLayout();
            dashboardForm.Location = this.Location;
            dashboardForm.StartPosition = this.StartPosition;
            dashboardForm.WindowState = FormWindowState.Normal;
            dashboardForm.titleOfDataLabel.Text = "Edit Inventory Item";
            dashboardForm.Show();
            this.Hide();
        }

        private void removeItemToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var dashboardForm = new BasicLayout();
            dashboardForm.Location = this.Location;
            dashboardForm.StartPosition = this.StartPosition;
            dashboardForm.WindowState = FormWindowState.Normal;
            dashboardForm.titleOfDataLabel.Text = "Remove Inventory Item";
            dashboardForm.Show();
            this.Hide();
        }

        private void reportsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var dashboardForm = new BasicLayout();
            dashboardForm.Location = this.Location;
            dashboardForm.StartPosition = this.StartPosition;
            dashboardForm.WindowState = FormWindowState.Normal;
            dashboardForm.titleOfDataLabel.Text = "Reports";
            dashboardForm.Show();
            this.Hide();
        }
    }
}
