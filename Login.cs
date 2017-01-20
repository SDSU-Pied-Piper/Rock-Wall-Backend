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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            this.KeyPreview = true;           
        }
        private string hashPassword(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashbytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashbytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashbytes);
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            if (this.usernameField.Text != "" && this.passwordField.Text != "")
            {   
                var hashedPassword = hashPassword(this.passwordField.Text);
                try
                {
                    Database db = new Database();
                    SqlCommand command = new SqlCommand("Select * from Admins where username=@username and password=@password", db.con);
                    command.Parameters.AddWithValue("@username", this.usernameField.Text);
                    command.Parameters.AddWithValue("@password", hashedPassword);
                    DataSet returnedData = new DataSet();
                    returnedData = db.sendSelectCommand(command);
                    if (returnedData.Tables[0].Rows.Count == 1)
                    {
                        var dashboardForm = new Dashboard();
                        dashboardForm.Location = this.Location;
                        dashboardForm.StartPosition = this.StartPosition;
                        dashboardForm.WindowState = FormWindowState.Normal;
                        dashboardForm.Show();
                        this.Close();
                    }
                    else
                    {
                        command = new SqlCommand("Select * from Masters where username=@username and password=@password", db.con);
                        command.Parameters.AddWithValue("@username", this.usernameField.Text);
                        command.Parameters.AddWithValue("@password", hashedPassword);
                        returnedData.Reset();
                        returnedData = db.sendSelectCommand(command);
                        if (returnedData.Tables[0].Rows.Count == 1)
                        {
                            var dashboardForm = new Dashboard();
                            dashboardForm.Location = this.Location;
                            dashboardForm.StartPosition = this.StartPosition;
                            dashboardForm.WindowState = FormWindowState.Normal;
                            dashboardForm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Either username and/or password is incorrect");
                            this.passwordField.Text = "";
                            this.usernameField.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
