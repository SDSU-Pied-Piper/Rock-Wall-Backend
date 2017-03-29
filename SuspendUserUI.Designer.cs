namespace SDSU_Rock_Wall_CRM
{
    partial class SuspendUserUI
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
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonUpdatePatron = new System.Windows.Forms.Button();
            this.searchUserButton = new System.Windows.Forms.Button();
            this.firstNameSearch = new System.Windows.Forms.TextBox();
            this.dobSearch = new System.Windows.Forms.TextBox();
            this.lastNameSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToDeleteRows = false;
            this.userDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.userDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.userDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Location = new System.Drawing.Point(17, 175);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowHeadersVisible = false;
            this.userDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDataGridView.Size = new System.Drawing.Size(1213, 494);
            this.userDataGridView.TabIndex = 17;
            // 
            // buttonUpdatePatron
            // 
            this.buttonUpdatePatron.Location = new System.Drawing.Point(1142, 102);
            this.buttonUpdatePatron.Name = "buttonUpdatePatron";
            this.buttonUpdatePatron.Size = new System.Drawing.Size(87, 23);
            this.buttonUpdatePatron.TabIndex = 19;
            this.buttonUpdatePatron.Text = "Update Patron";
            this.buttonUpdatePatron.UseVisualStyleBackColor = true;
            this.buttonUpdatePatron.Click += new System.EventHandler(this.buttonUpdatePatron_Click);
            // 
            // searchUserButton
            // 
            this.searchUserButton.Location = new System.Drawing.Point(1142, 131);
            this.searchUserButton.Name = "searchUserButton";
            this.searchUserButton.Size = new System.Drawing.Size(87, 23);
            this.searchUserButton.TabIndex = 26;
            this.searchUserButton.Text = "Search User";
            this.searchUserButton.UseVisualStyleBackColor = true;
            this.searchUserButton.Click += new System.EventHandler(this.searchUserButton_Click);
            // 
            // firstNameSearch
            // 
            this.firstNameSearch.Location = new System.Drawing.Point(793, 134);
            this.firstNameSearch.Name = "firstNameSearch";
            this.firstNameSearch.Size = new System.Drawing.Size(100, 20);
            this.firstNameSearch.TabIndex = 25;
            this.firstNameSearch.Text = "First Name...";
            // 
            // dobSearch
            // 
            this.dobSearch.Location = new System.Drawing.Point(1005, 134);
            this.dobSearch.Name = "dobSearch";
            this.dobSearch.Size = new System.Drawing.Size(100, 20);
            this.dobSearch.TabIndex = 24;
            this.dobSearch.Text = "DOB MM-DD-YYYY";
            // 
            // lastNameSearch
            // 
            this.lastNameSearch.Location = new System.Drawing.Point(899, 134);
            this.lastNameSearch.Name = "lastNameSearch";
            this.lastNameSearch.Size = new System.Drawing.Size(100, 20);
            this.lastNameSearch.TabIndex = 23;
            this.lastNameSearch.Text = "Last Name...";
            // 
            // SuspendUserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.searchUserButton);
            this.Controls.Add(this.firstNameSearch);
            this.Controls.Add(this.dobSearch);
            this.Controls.Add(this.lastNameSearch);
            this.Controls.Add(this.buttonUpdatePatron);
            this.Controls.Add(this.userDataGridView);
            this.Name = "SuspendUserUI";
            this.Text = "SuspendUserUI";
            this.Load += new System.EventHandler(this.SuspendUserUI_Load);
            this.Controls.SetChildIndex(this.titleOfDataLabel, 0);
            this.Controls.SetChildIndex(this.userDataGridView, 0);
            this.Controls.SetChildIndex(this.buttonUpdatePatron, 0);
            this.Controls.SetChildIndex(this.lastNameSearch, 0);
            this.Controls.SetChildIndex(this.dobSearch, 0);
            this.Controls.SetChildIndex(this.firstNameSearch, 0);
            this.Controls.SetChildIndex(this.searchUserButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Button buttonUpdatePatron;
        private System.Windows.Forms.Button searchUserButton;
        private System.Windows.Forms.TextBox firstNameSearch;
        private System.Windows.Forms.TextBox dobSearch;
        private System.Windows.Forms.TextBox lastNameSearch;
    }
}