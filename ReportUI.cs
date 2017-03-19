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
    public partial class ReportUI : BasicLayout
    {
        public ReportUI()
        {
            InitializeComponent();
            this.titleOfDataLabel.Text = "Generate Reports";
            this.reportListing.SelectionMode = SelectionMode.One;
            this.reportListing.Items.Add("Master Report");
            this.reportListing.Items.Add("Inventory Report");
            this.reportListing.Items.Add("Suspension Report");
            this.reportListing.Items.Add("Certified Users Report");
        }

        private void moveRightButton_Click(object sender, EventArgs e)
        {
            if(this.reportListing.SelectedItem != null)
            {
                this.generateReportsListing.Items.Add(this.reportListing.SelectedItem);
                this.reportListing.Items.Remove(this.reportListing.SelectedItem);
            }
        }

        private void moveLeftButton_Click(object sender, EventArgs e)
        {
            if(this.generateReportsListing.SelectedItem != null)
            {
                this.reportListing.Items.Add(this.generateReportsListing.SelectedItem);
                this.generateReportsListing.Items.Remove(this.generateReportsListing.SelectedItem);
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var r = new Report();
            foreach (var item in generateReportsListing.Items)
            {
                if(item.ToString() == "Master Report")
                {
                    r.generateMasterReport();
                }
                else if(item.ToString() == "Inventory Report")
                {
                    r.generateInventoryReport();  
                }
                else if(item.ToString() == "Suspension Report")
                {
                    r.generateSuspensionList();
                }
                else if(item.ToString() == "Certified Users Report")
                {
                    r.generateCertifiedUsersReport();
                }
            }
        }
    }
}
