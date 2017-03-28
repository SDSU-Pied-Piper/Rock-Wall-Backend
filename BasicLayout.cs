using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SDSU_Rock_Wall_CRM
{
    public partial class BasicLayout : Form
    {
        public BasicLayout()
        {
            InitializeComponent();
            var todayTotalUserInsightPrefix = "Today's Patrons: ";
            var todayTotalNewUserInsightPrefix = "Today's New Patrons: ";
            var dateOfToday = DateTime.Today.ToShortDateString();
            StringBuilder todayTotalUserInsightText = new StringBuilder();
            try
            {
                Database db = new Database();
                SqlCommand command = new SqlCommand("Select * from Patrons where lastCheckIn=@dateOfToday", db.con);
                command.Parameters.AddWithValue("@dateOfToday", dateOfToday);
                DataSet returnedData = new DataSet();
                returnedData = db.sendSelectCommand(command);
                if (returnedData.Tables[0].Rows.Count <= 0)
                {
                    todayTotalUserInsightText.Append($"{todayTotalUserInsightPrefix} 0");
                }
                else
                {
                    todayTotalUserInsightText.Append($"{todayTotalUserInsightPrefix} {returnedData.Tables[0].Rows.Count}");
                }
                this.todayTotalPatronInsightButton.Text = todayTotalUserInsightText.ToString();
                todayTotalUserInsightText.Clear();

                command.Parameters.Clear();
                command.CommandText = "Select * from Patrons where dateOfCreation=@dateOfToday";
                command.Parameters.AddWithValue("@dateOfToday", dateOfToday);
                returnedData.Reset();
                returnedData = db.sendSelectCommand(command);
                if (returnedData.Tables[0].Rows.Count <= 0)
                {
                    todayTotalUserInsightText.Append($"{todayTotalNewUserInsightPrefix} 0");
                }
                else
                {
                    todayTotalUserInsightText.Append($"{todayTotalNewUserInsightPrefix} {returnedData.Tables[0].Rows.Count}");
                }
                this.todayNewPatronInsightButton.Text = todayTotalUserInsightText.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var dashBoard = new Dashboard();
            dashBoard.Location = this.Location;
            dashBoard.StartPosition = this.StartPosition;
            dashBoard.WindowState = FormWindowState.Normal;
            dashBoard.Show();
            this.Hide();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashBoard = new BasicLayout();
            dashBoard.Location = this.Location;
            dashBoard.StartPosition = this.StartPosition;
            dashBoard.WindowState = FormWindowState.Normal;
            dashBoard.titleOfDataLabel.Text = "Add User";
            dashBoard.Show();
            this.Hide();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashBoard = new BasicLayout();
            dashBoard.Location = this.Location;
            dashBoard.StartPosition = this.StartPosition;
            dashBoard.WindowState = FormWindowState.Normal;
            dashBoard.titleOfDataLabel.Text = "Edit User";
            dashBoard.Show();
            this.Hide();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashBoard = new BasicLayout();
            dashBoard.Location = this.Location;
            dashBoard.StartPosition = this.StartPosition;
            dashBoard.WindowState = FormWindowState.Normal;
            dashBoard.titleOfDataLabel.Text = "Delete User";
            dashBoard.Show();
            this.Hide();
        }

        private void viewPendingSuspensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashBoard = new BasicLayout();
            dashBoard.Location = this.Location;
            dashBoard.StartPosition = this.StartPosition;
            dashBoard.WindowState = FormWindowState.Normal;
            dashBoard.titleOfDataLabel.Text = "Pending Suspensions";
            dashBoard.Show();
            this.Hide();
        }
        private void suspendUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashBoard = new BasicLayout();
            dashBoard.Location = this.Location;
            dashBoard.StartPosition = this.StartPosition;
            dashBoard.WindowState = FormWindowState.Normal;
            dashBoard.titleOfDataLabel.Text = "Suspend User";
            dashBoard.Show();
            this.Hide();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashBoard = new ReportUI();
            dashBoard.Location = this.Location;
            dashBoard.StartPosition = this.StartPosition;
            dashBoard.WindowState = FormWindowState.Normal;
            dashBoard.Show();
            this.Hide();
        }

        private void manageInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashboardForm = new InventoryUI();
            dashboardForm.Location = this.Location;
            dashboardForm.StartPosition = this.StartPosition;
            dashboardForm.WindowState = FormWindowState.Normal;
            dashboardForm.titleOfDataLabel.Text = "Manage Inventory";
            dashboardForm.Show();
            var inventory = new Inventory();
            this.Hide();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashboardForm = new ManageUserUI();
            dashboardForm.Location = this.Location;
            dashboardForm.StartPosition = this.StartPosition;
            dashboardForm.WindowState = FormWindowState.Normal;
            dashboardForm.titleOfDataLabel.Text = "Manage Inventory";
            dashboardForm.Show();
            this.Hide();
        }
    }
}
