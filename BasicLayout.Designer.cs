﻿namespace SDSU_Rock_Wall_CRM
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
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suspensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPendingSuspensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueSuspensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suspendUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dashboardMenuStrip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dashboardMenuStrip.Size = new System.Drawing.Size(1904, 24);
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
            this.manageUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editUserToolStripMenuItem.Text = "Edit User";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // suspensionsToolStripMenuItem
            // 
            this.suspensionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPendingSuspensionsToolStripMenuItem,
            this.issueSuspensionToolStripMenuItem,
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
            // issueSuspensionToolStripMenuItem
            // 
            this.issueSuspensionToolStripMenuItem.Name = "issueSuspensionToolStripMenuItem";
            this.issueSuspensionToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.issueSuspensionToolStripMenuItem.Text = "View Incedents";
            this.issueSuspensionToolStripMenuItem.Click += new System.EventHandler(this.issueSuspensionToolStripMenuItem_Click);
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
            this.manageInventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.editItemToolStripMenuItem,
            this.removeItemToolStripMenuItem});
            this.manageInventoryToolStripMenuItem.Name = "manageInventoryToolStripMenuItem";
            this.manageInventoryToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.manageInventoryToolStripMenuItem.Text = "Manage Inventory";
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addItemToolStripMenuItem.Text = "Add Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editItemToolStripMenuItem.Text = "Edit Item";
            this.editItemToolStripMenuItem.Click += new System.EventHandler(this.editItemToolStripMenuItem_Click);
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeItemToolStripMenuItem.Text = "Remove Item";
            this.removeItemToolStripMenuItem.Click += new System.EventHandler(this.removeItemToolStripMenuItem_Click);
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
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1879, 73);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(840, 25, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Highlight 1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(958, 25);
            this.button2.Margin = new System.Windows.Forms.Padding(40, 25, 3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Highlight 2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title of Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1872, 759);
            this.dataGridView1.TabIndex = 4;
            // 
            // BasicLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dashboardMenuStrip);
            this.Name = "BasicLayout";
            this.Text = "BasicLayout";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.dashboardMenuStrip.ResumeLayout(false);
            this.dashboardMenuStrip.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip dashboardMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suspensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPendingSuspensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueSuspensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suspendUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}