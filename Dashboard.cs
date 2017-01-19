using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string connectionString = "Data Source = sqlpiedpiper.database.windows.net; Initial Catalog=RockWallSDSU; Persist Security Info = True; User ID = devadmin; Password = P@ssword";
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("Select * from Patrons where lastCheckIn=@dateOfToday", con);
                command.Parameters.AddWithValue("@dateOfToday", dateOfToday);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                DataSet returnedData = new DataSet();
                adapt.Fill(returnedData);
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
                adapt.SelectCommand = command;
                returnedData.Reset();
                adapt.Fill(returnedData);
                if (returnedData.Tables[0].Rows.Count <= 0)
                {
                    todayTotalUserInsightText.Append($"{todayTotalNewUserInsightPrefix} 0");
                }
                else
                {
                    todayTotalUserInsightText.Append($"{todayTotalNewUserInsightPrefix} {returnedData.Tables[0].Rows.Count}");
                }
                this.todayNewPatronInsightButton.Text = todayTotalUserInsightText.ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
