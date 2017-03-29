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
    public partial class ManageUserUI : BasicLayout
    {
        public ManageUserUI()
        {
            InitializeComponent();
            this.titleOfDataLabel.Text = "Manage User";
            this.userDataGridView.AllowUserToAddRows = false;
        }

        private void ManageUserUI_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            SqlCommand command = new SqlCommand("Select id,firstName,lastName,studentID,dateOfBirth,gender,email,isWaiverSigned,isBlayCertified,isLeadCertified,isSuspended,dateSuspended,dateUnsuspended,lastCheckIn From Patrons Where isWaiverSigned=1", db.con);
            DataSet returnedData = db.sendSelectCommand(command);
            this.userDataGridView.DataSource = returnedData.Tables[0];
            #region Table Formatting
            this.userDataGridView.Columns[0].HeaderText = "ID";
            this.userDataGridView.Columns[1].HeaderText = "First Name";
            this.userDataGridView.Columns[2].HeaderText = "Last Name";
            this.userDataGridView.Columns[3].HeaderText = "Student ID";
            this.userDataGridView.Columns[4].HeaderText = "Date Of Birth";
            this.userDataGridView.Columns[5].HeaderText = "Gender";
            this.userDataGridView.Columns[6].HeaderText = "Email";
            this.userDataGridView.Columns[7].HeaderText = "Is Waiver Signed";
            this.userDataGridView.Columns[8].HeaderText = "Is Blay Certified";
            this.userDataGridView.Columns[9].HeaderText = "Is Lead Certified";
            this.userDataGridView.Columns[10].HeaderText = "Is Suspended";
            this.userDataGridView.Columns[11].HeaderText = "Date Suspended";
            this.userDataGridView.Columns[12].HeaderText = "Date Unsuspended";
            this.userDataGridView.Columns[13].HeaderText = "Last Check In";
            this.userDataGridView.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.userDataGridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.userDataGridView.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.userDataGridView.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.userDataGridView.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.userDataGridView.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.userDataGridView.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.userDataGridView.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.userDataGridView.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.userDataGridView.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.userDataGridView.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.userDataGridView.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.userDataGridView.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.userDataGridView.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.userDataGridView.Columns[0].ReadOnly = true;
            this.userDataGridView.Columns[1].ReadOnly = true;
            this.userDataGridView.Columns[2].ReadOnly = true;
            this.userDataGridView.Columns[3].ReadOnly = true;
            this.userDataGridView.Columns[4].ReadOnly = true;
            this.userDataGridView.Columns[5].ReadOnly = true;
            this.userDataGridView.Columns[6].ReadOnly = true;
            this.userDataGridView.Columns[7].ReadOnly = true;
            this.userDataGridView.Columns[10].ReadOnly = true;
            this.userDataGridView.Columns[11].ReadOnly = true;
            this.userDataGridView.Columns[12].ReadOnly = true;
            this.userDataGridView.Columns[13].ReadOnly = true;
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            SqlCommand command = new SqlCommand("Select id,firstName,lastName,studentID,dateOfBirth,gender,email,isWaiverSigned,isBlayCertified,isLeadCertified,isSuspended,dateSuspended,dateUnsuspended,lastCheckIn From Patrons Where isWaiverSigned=1 And firstName=@firstName And lastName=@lastName And dateOfBirth=@dateOfBirth", db.con);
            command.Parameters.AddWithValue("@firstName",firstNameSearch.Text.ToString());
            command.Parameters.AddWithValue("@lastName", lastNameSearch.Text.ToString());
            try
            {
                command.Parameters.AddWithValue("@dateOfBirth", DateTime.Parse(dobSearch.Text.ToString()).ToShortDateString());
                DataSet returnedDate = db.sendSelectCommand(command);
                this.userDataGridView.DataSource = returnedDate.Tables[0];
                #region Table Headings Button
                this.userDataGridView.Columns[0].HeaderText = "ID";
                this.userDataGridView.Columns[1].HeaderText = "First Name";
                this.userDataGridView.Columns[2].HeaderText = "Last Name";
                this.userDataGridView.Columns[3].HeaderText = "Student ID";
                this.userDataGridView.Columns[4].HeaderText = "Date Of Birth";
                this.userDataGridView.Columns[5].HeaderText = "Gender";
                this.userDataGridView.Columns[6].HeaderText = "Email";
                this.userDataGridView.Columns[7].HeaderText = "Is Waiver Signed";
                this.userDataGridView.Columns[8].HeaderText = "Is Blay Certified";
                this.userDataGridView.Columns[9].HeaderText = "Is Lead Certified";
                this.userDataGridView.Columns[10].HeaderText = "Is Suspended";
                this.userDataGridView.Columns[11].HeaderText = "Date Suspended";
                this.userDataGridView.Columns[12].HeaderText = "Date Unsuspended";
                this.userDataGridView.Columns[13].HeaderText = "Last Check In";
                this.userDataGridView.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.userDataGridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.userDataGridView.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.userDataGridView.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.userDataGridView.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.userDataGridView.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.userDataGridView.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.userDataGridView.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.userDataGridView.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.userDataGridView.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.userDataGridView.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.userDataGridView.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.userDataGridView.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.userDataGridView.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.userDataGridView.Columns[0].ReadOnly = true;
                this.userDataGridView.Columns[1].ReadOnly = true;
                this.userDataGridView.Columns[2].ReadOnly = true;
                this.userDataGridView.Columns[3].ReadOnly = true;
                this.userDataGridView.Columns[4].ReadOnly = true;
                this.userDataGridView.Columns[5].ReadOnly = true;
                this.userDataGridView.Columns[6].ReadOnly = true;
                this.userDataGridView.Columns[7].ReadOnly = true;
                this.userDataGridView.Columns[10].ReadOnly = true;
                this.userDataGridView.Columns[11].ReadOnly = true;
                this.userDataGridView.Columns[12].ReadOnly = true;
                this.userDataGridView.Columns[13].ReadOnly = true;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please put a correct date format in the field!");
                this.userDataGridView = new DataGridView();
            }

        }

        private void buttonUpdatePatron_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            SqlCommand command = new SqlCommand("Update Patrons Set isBlayCertified=@isBlayCertified, isLeadCertified=@isLeadCertified Where firstName=@firstName And lastName=@lastName And dateOfBirth=@dateOfBirth", db.con);
            int currentSelectedIndex = userDataGridView.CurrentRow.Index;
            if(Convert.ToBoolean(userDataGridView.Rows[currentSelectedIndex].Cells[8].Value) == true)
            {
                command.Parameters.AddWithValue("@isBlayCertified", 1);
            }
            else
            {
                command.Parameters.AddWithValue("@isBlayCertified", 0);
            }
            if (Convert.ToBoolean(userDataGridView.Rows[currentSelectedIndex].Cells[9].Value) == true)
            {
                command.Parameters.AddWithValue("@isLeadCertified", 1);
            }
            else
            {
                command.Parameters.AddWithValue("@isLeadCertified", 0);
            }
            command.Parameters.AddWithValue("@firstName", userDataGridView.Rows[currentSelectedIndex].Cells[1].Value.ToString());
            command.Parameters.AddWithValue("@lastName", userDataGridView.Rows[currentSelectedIndex].Cells[2].Value.ToString());
            command.Parameters.AddWithValue("@dateOfBirth", DateTime.Parse(userDataGridView.Rows[currentSelectedIndex].Cells[4].Value.ToString()).ToShortDateString());
            db.sendUpdateCommand(command);
        }

        private void buttonSeeWaiver_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            int currentSelectedIndex = userDataGridView.CurrentRow.Index;
            var displayWaiverBox = new DisplayWaiverUI(db.getImage(userDataGridView.Rows[currentSelectedIndex].Cells[1].Value.ToString(), userDataGridView.Rows[currentSelectedIndex].Cells[2].Value.ToString(), userDataGridView.Rows[currentSelectedIndex].Cells[4].Value.ToString()),userDataGridView.Rows[currentSelectedIndex].Cells[1].Value.ToString(), userDataGridView.Rows[currentSelectedIndex].Cells[2].Value.ToString());
            displayWaiverBox.Show();
        }
    }
}
