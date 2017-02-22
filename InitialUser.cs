using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SDSU_Rock_Wall_CRM
{
    public partial class InitialUser : Form
    {
        public InitialUser()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.addManager.Checked = false;
        }

        private void addManager_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButton2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked == true)
            {
                var db = new Database();
                SqlCommand checkDuplicate = new SqlCommand("Select * from Masters where username=@username", db.con);
                checkDuplicate.Parameters.AddWithValue("@username", this.userNameTextBox.Text.ToString());
                DataSet userDuplicate = db.sendSelectCommand(checkDuplicate);
                if (userDuplicate.Tables[0].Rows.Count > 0)
                {
                    this.userNameTextBox.Text = "";
                    this.passwordTextBox.Text = "";
                    MessageBox.Show("Error: Username already exists.");
                }
                else
                {
                    SqlCommand command = new SqlCommand("Insert Into Masters Values (@username,@password)", db.con);
                    var hashedPassword = loginForm.hashPassword(passwordTextBox.Text.ToString());
                    command.Parameters.AddWithValue("@username", this.userNameTextBox.Text.ToString());
                    command.Parameters.AddWithValue("@password", hashedPassword);
                    db.sendInsertCommand(command);
                    MessageBox.Show("Inserted Account Successfully!");
                }
            }
            else
            {
                var db = new Database();
                SqlCommand checkDuplicate = new SqlCommand("Select * from Admins where username=@username", db.con);
                checkDuplicate.Parameters.AddWithValue("@username", this.userNameTextBox.Text.ToString());
                DataSet userDuplicate = db.sendSelectCommand(checkDuplicate);
                if (userDuplicate.Tables[0].Rows.Count > 0)
                {
                    this.userNameTextBox.Text = "";
                    this.passwordTextBox.Text = "";
                    MessageBox.Show("Error: Username already exists.");
                }
                else
                {
                    SqlCommand command = new SqlCommand("Insert Into Admins Values (@username,@password)", db.con);
                    var hashedPassword = loginForm.hashPassword(passwordTextBox.Text.ToString());
                    command.Parameters.AddWithValue("@username", this.userNameTextBox.Text.ToString());
                    command.Parameters.AddWithValue("@password", hashedPassword);
                    db.sendInsertCommand(command);
                    MessageBox.Show("Inserted Account Successfully!");
                }
            }
            this.userNameTextBox.Text = "";
            this.passwordTextBox.Text = "";
        }
    }
}
