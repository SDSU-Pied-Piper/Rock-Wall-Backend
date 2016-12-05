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
    public partial class BasicLayout : Form
    {
        public BasicLayout()
        {
            InitializeComponent();
        }
        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var dashBoard = new Dashboard();
            dashBoard.Location = this.Location;
            dashBoard.StartPosition = this.StartPosition;
            dashBoard.WindowState = FormWindowState.Maximized;
            dashBoard.Show();
            this.Hide();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashBoard = new BasicLayout();
            dashBoard.Location = this.Location;
            dashBoard.StartPosition = this.StartPosition;
            dashBoard.WindowState = FormWindowState.Maximized;
            dashBoard.Show();
            this.Hide();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashBoard = new BasicLayout();
            dashBoard.Location = this.Location;
            dashBoard.StartPosition = this.StartPosition;
            dashBoard.WindowState = FormWindowState.Maximized;
            dashBoard.Show();
            this.Hide();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashBoard = new BasicLayout();
            dashBoard.Location = this.Location;
            dashBoard.StartPosition = this.StartPosition;
            dashBoard.WindowState = FormWindowState.Maximized;
            dashBoard.Show();
            this.Hide();
        }

        private void viewPendingSuspensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashBoard = new BasicLayout();
            dashBoard.Location = this.Location;
            dashBoard.StartPosition = this.StartPosition;
            dashBoard.WindowState = FormWindowState.Maximized;
            dashBoard.Show();
            this.Hide();
        }

        private void issueSuspensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashBoard = new BasicLayout();
            dashBoard.Location = this.Location;
            dashBoard.StartPosition = this.StartPosition;
            dashBoard.WindowState = FormWindowState.Maximized;
            dashBoard.Show();
            this.Hide();
        }

        private void suspendUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashBoard = new BasicLayout();
            dashBoard.Location = this.Location;
            dashBoard.StartPosition = this.StartPosition;
            dashBoard.WindowState = FormWindowState.Maximized;
            dashBoard.Show();
            this.Hide();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashBoard = new BasicLayout();
            dashBoard.Location = this.Location;
            dashBoard.StartPosition = this.StartPosition;
            dashBoard.WindowState = FormWindowState.Maximized;
            dashBoard.Show();
            this.Hide();
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashBoard = new BasicLayout();
            dashBoard.Location = this.Location;
            dashBoard.StartPosition = this.StartPosition;
            dashBoard.WindowState = FormWindowState.Maximized;
            dashBoard.Show();
            this.Hide();
        }

        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashBoard = new BasicLayout();
            dashBoard.Location = this.Location;
            dashBoard.StartPosition = this.StartPosition;
            dashBoard.WindowState = FormWindowState.Maximized;
            dashBoard.Show();
            this.Hide();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashBoard = new BasicLayout();
            dashBoard.Location = this.Location;
            dashBoard.StartPosition = this.StartPosition;
            dashBoard.WindowState = FormWindowState.Maximized;
            dashBoard.Show();
            this.Hide();
        }
    }
}
