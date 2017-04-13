namespace SDSU_Rock_Wall_CRM
{
    partial class ManageUserUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserUI));
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSeeWaiver = new System.Windows.Forms.Button();
            this.buttonUpdatePatron = new System.Windows.Forms.Button();
            this.lastNameSearch = new System.Windows.Forms.TextBox();
            this.dobSearch = new System.Windows.Forms.TextBox();
            this.firstNameSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userDataGridView
            // 
            this.userDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.userDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.userDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Location = new System.Drawing.Point(26, 175);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowHeadersVisible = false;
            this.userDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDataGridView.Size = new System.Drawing.Size(1213, 494);
            this.userDataGridView.TabIndex = 16;
            // 
            // buttonSeeWaiver
            // 
            this.buttonSeeWaiver.Location = new System.Drawing.Point(1154, 136);
            this.buttonSeeWaiver.Name = "buttonSeeWaiver";
            this.buttonSeeWaiver.Size = new System.Drawing.Size(87, 23);
            this.buttonSeeWaiver.TabIndex = 17;
            this.buttonSeeWaiver.Text = "See Waiver";
            this.buttonSeeWaiver.UseVisualStyleBackColor = true;
            this.buttonSeeWaiver.Click += new System.EventHandler(this.buttonSeeWaiver_Click);
            // 
            // buttonUpdatePatron
            // 
            this.buttonUpdatePatron.Location = new System.Drawing.Point(1061, 106);
            this.buttonUpdatePatron.Name = "buttonUpdatePatron";
            this.buttonUpdatePatron.Size = new System.Drawing.Size(87, 23);
            this.buttonUpdatePatron.TabIndex = 18;
            this.buttonUpdatePatron.Text = "Update Patron";
            this.buttonUpdatePatron.UseVisualStyleBackColor = true;
            this.buttonUpdatePatron.Click += new System.EventHandler(this.buttonUpdatePatron_Click);
            // 
            // lastNameSearch
            // 
            this.lastNameSearch.Location = new System.Drawing.Point(832, 139);
            this.lastNameSearch.Name = "lastNameSearch";
            this.lastNameSearch.Size = new System.Drawing.Size(100, 20);
            this.lastNameSearch.TabIndex = 19;
            this.lastNameSearch.Text = "Last Name...";
            // 
            // dobSearch
            // 
            this.dobSearch.Location = new System.Drawing.Point(938, 139);
            this.dobSearch.Name = "dobSearch";
            this.dobSearch.Size = new System.Drawing.Size(100, 20);
            this.dobSearch.TabIndex = 20;
            this.dobSearch.Text = "DOB MM-DD-YYYY";
            // 
            // firstNameSearch
            // 
            this.firstNameSearch.Location = new System.Drawing.Point(726, 139);
            this.firstNameSearch.Name = "firstNameSearch";
            this.firstNameSearch.Size = new System.Drawing.Size(100, 20);
            this.firstNameSearch.TabIndex = 21;
            this.firstNameSearch.Text = "First Name...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1061, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Search User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageUserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.firstNameSearch);
            this.Controls.Add(this.dobSearch);
            this.Controls.Add(this.lastNameSearch);
            this.Controls.Add(this.buttonUpdatePatron);
            this.Controls.Add(this.buttonSeeWaiver);
            this.Controls.Add(this.userDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageUserUI";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUserUI_Load);
            this.Controls.SetChildIndex(this.titleOfDataLabel, 0);
            this.Controls.SetChildIndex(this.userDataGridView, 0);
            this.Controls.SetChildIndex(this.buttonSeeWaiver, 0);
            this.Controls.SetChildIndex(this.buttonUpdatePatron, 0);
            this.Controls.SetChildIndex(this.lastNameSearch, 0);
            this.Controls.SetChildIndex(this.dobSearch, 0);
            this.Controls.SetChildIndex(this.firstNameSearch, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Button buttonSeeWaiver;
        private System.Windows.Forms.Button buttonUpdatePatron;
        private System.Windows.Forms.TextBox lastNameSearch;
        private System.Windows.Forms.TextBox dobSearch;
        private System.Windows.Forms.TextBox firstNameSearch;
        private System.Windows.Forms.Button button1;
    }
}