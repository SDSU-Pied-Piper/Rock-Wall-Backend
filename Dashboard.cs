using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SDSU_Rock_Wall_CRM
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            var todayTotalUserInsightPrefix = "Today's Patrons: ";
            var todayTotalNewUserInsightPrefix = "Today's New Patrons: ";
            var dateOfToday = DateTime.Today.ToShortDateString();
            StringBuilder todayTotalUserInsightText = new StringBuilder();
            try
            {
                Database db = new Database();
                SqlCommand command = new SqlCommand("Select * from Patrons Where lastCheckIn=@dateOfToday", db.con);
                command.Parameters.AddWithValue("@dateOfToday", dateOfToday);
                DataSet returnedData = new DataSet();
                returnedData = db.sendSelectCommand(command);
                if(returnedData.Tables[0].Rows.Count <= 0)
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
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        private void Dashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7 && e.Control && e.Alt)
            {
                var newForm = new InitialUser();
                newForm.Show();
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

        private void reportsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var dashboardForm = new ReportUI();
            dashboardForm.Location = this.Location;
            dashboardForm.StartPosition = this.StartPosition;
            dashboardForm.WindowState = FormWindowState.Normal;
            dashboardForm.Show();
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

        private void loadTables(object sender, EventArgs e)
        {
            Database db = new Database();
            SqlCommand command = new SqlCommand("Select firstName,lastName From Patrons Where isWaiverSigned=1 And dateOfCreation=@dateCreated", db.con);
            command.Parameters.AddWithValue("@dateCreated", DateTime.Now.ToShortDateString());
            DataSet newPatrons = db.sendSelectCommand(command);
            this.newPatronsList.DataSource = newPatrons.Tables[0];
            this.newPatronsList.Columns[0].HeaderText = "First Name";
            this.newPatronsList.Columns[1].HeaderText = "Last Name";
            this.newPatronsList.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.newPatronsList.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            command.CommandText = "Select firstName,lastName from Patrons Where isWaiverSigned=1 And isSuspended=0 And suspensionReason Is Not NULL";
            DataSet unhandeledSuspensions = db.sendSelectCommand(command);
            this.unhandeledIncidentsList.DataSource = unhandeledSuspensions.Tables[0];
            this.unhandeledIncidentsList.Columns[0].HeaderText = "First Name";
            this.unhandeledIncidentsList.Columns[1].HeaderText = "Last Name";
            this.unhandeledIncidentsList.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.unhandeledIncidentsList.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            command.CommandText = "Select firstName,lastName From Patrons Where isWaiverSigned=1 And isSuspended=1";
            DataSet susependedUsers = db.sendSelectCommand(command);
            this.currentSuspensionsList.DataSource = susependedUsers.Tables[0];
            this.currentSuspensionsList.Columns[0].HeaderText = "First Name";
            this.currentSuspensionsList.Columns[1].HeaderText = "Last Name";
            this.currentSuspensionsList.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.currentSuspensionsList.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashboardForm = new ManageUserUI();
            dashboardForm.Location = this.Location;
            dashboardForm.StartPosition = this.StartPosition;
            dashboardForm.WindowState = FormWindowState.Normal;
            dashboardForm.titleOfDataLabel.Text = "Manage Users";
            dashboardForm.Show();
            this.Hide();
        }

        private void suspensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashboardForm = new SuspendUserUI();
            dashboardForm.Location = this.Location;
            dashboardForm.StartPosition = this.StartPosition;
            dashboardForm.WindowState = FormWindowState.Normal;
            dashboardForm.titleOfDataLabel.Text = "Suspend Users";
            dashboardForm.Show();
            this.Hide();
        }
    }
}
