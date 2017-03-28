namespace SDSU_Rock_Wall_CRM
{
    partial class BasicLayout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dashboardMenuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suspensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPendingSuspensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suspendUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.todayTotalPatronInsightButton = new System.Windows.Forms.Button();
            this.todayNewPatronInsightButton = new System.Windows.Forms.Button();
            this.titleOfDataLabel = new System.Windows.Forms.Label();
            this.dashboardMenuStrip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardMenuStrip
            // 
            this.dashboardMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.manageUsersToolStripMenuItem,
            this.suspensionsToolStripMenuItem,
            this.manageInventoryToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.dashboardMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.dashboardMenuStrip.Name = "dashboardMenuStrip";
            this.dashboardMenuStrip.Size = new System.Drawing.Size(1264, 24);
            this.dashboardMenuStrip.TabIndex = 1;
            this.dashboardMenuStrip.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click_1);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // suspensionsToolStripMenuItem
            // 
            this.suspensionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPendingSuspensionsToolStripMenuItem,
            this.suspendUserToolStripMenuItem});
            this.suspensionsToolStripMenuItem.Name = "suspensionsToolStripMenuItem";
            this.suspensionsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.suspensionsToolStripMenuItem.Text = "Suspensions";
            // 
            // viewPendingSuspensionsToolStripMenuItem
            // 
            this.viewPendingSuspensionsToolStripMenuItem.Name = "viewPendingSuspensionsToolStripMenuItem";
            this.viewPendingSuspensionsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.viewPendingSuspensionsToolStripMenuItem.Text = "View Pending Suspensions";
            this.viewPendingSuspensionsToolStripMenuItem.Click += new System.EventHandler(this.viewPendingSuspensionsToolStripMenuItem_Click);
            // 
            // suspendUserToolStripMenuItem
            // 
            this.suspendUserToolStripMenuItem.Name = "suspendUserToolStripMenuItem";
            this.suspendUserToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.suspendUserToolStripMenuItem.Text = "Suspend User";
            this.suspendUserToolStripMenuItem.Click += new System.EventHandler(this.suspendUserToolStripMenuItem_Click);
            // 
            // manageInventoryToolStripMenuItem
            // 
            this.manageInventoryToolStripMenuItem.Name = "manageInventoryToolStripMenuItem";
            this.manageInventoryToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.manageInventoryToolStripMenuItem.Text = "Manage Inventory";
            this.manageInventoryToolStripMenuItem.Click += new System.EventHandler(this.manageInventoryToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.todayTotalPatronInsightButton);
            this.flowLayoutPanel1.Controls.Add(this.todayNewPatronInsightButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1252, 73);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // todayTotalPatronInsightButton
            // 
            this.todayTotalPatronInsightButton.Location = new System.Drawing.Point(450, 25);
            this.todayTotalPatronInsightButton.Margin = new System.Windows.Forms.Padding(450, 25, 3, 3);
            this.todayTotalPatronInsightButton.Name = "todayTotalPatronInsightButton";
            this.todayTotalPatronInsightButton.Size = new System.Drawing.Size(145, 27);
            this.todayTotalPatronInsightButton.TabIndex = 0;
            this.todayTotalPatronInsightButton.Text = "Today\'s Patrons: 0";
            this.todayTotalPatronInsightButton.UseVisualStyleBackColor = true;
            // 
            // todayNewPatronInsightButton
            // 
            this.todayNewPatronInsightButton.Location = new System.Drawing.Point(638, 25);
            this.todayNewPatronInsightButton.Margin = new System.Windows.Forms.Padding(40, 25, 3, 3);
            this.todayNewPatronInsightButton.Name = "todayNewPatronInsightButton";
            this.todayNewPatronInsightButton.Size = new System.Drawing.Size(145, 27);
            this.todayNewPatronInsightButton.TabIndex = 1;
            this.todayNewPatronInsightButton.Text = "Today\'s New Patrons: 0";
            this.todayNewPatronInsightButton.UseVisualStyleBackColor = true;
            // 
            // titleOfDataLabel
            // 
            this.titleOfDataLabel.AutoSize = true;
            this.titleOfDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleOfDataLabel.Location = new System.Drawing.Point(12, 126);
            this.titleOfDataLabel.Name = "titleOfDataLabel";
            this.titleOfDataLabel.Size = new System.Drawing.Size(155, 29);
            this.titleOfDataLabel.TabIndex = 14;
            this.titleOfDataLabel.Text = "Title of Data";
            // 
            // BasicLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.titleOfDataLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dashboardMenuStrip);
            this.Name = "BasicLayout";
            this.Text = "BasicLayout";
            this.dashboardMenuStrip.ResumeLayout(false);
            this.dashboardMenuStrip.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip dashboardMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suspensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPendingSuspensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suspendUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Label titleOfDataLabel;
        public System.Windows.Forms.Button todayTotalPatronInsightButton;
        public System.Windows.Forms.Button todayNewPatronInsightButton;
    }
}