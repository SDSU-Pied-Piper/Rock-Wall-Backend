namespace SDSU_Rock_Wall_CRM
{
    partial class ReportUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportUI));
            this.reportListing = new System.Windows.Forms.ListBox();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.generateReportsListing = new System.Windows.Forms.ListBox();
            this.listingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportListing
            // 
            this.reportListing.BackColor = System.Drawing.SystemColors.Control;
            this.reportListing.FormattingEnabled = true;
            this.reportListing.Location = new System.Drawing.Point(200, 231);
            this.reportListing.Name = "reportListing";
            this.reportListing.Size = new System.Drawing.Size(238, 394);
            this.reportListing.TabIndex = 15;
            // 
            // moveRightButton
            // 
            this.moveRightButton.Location = new System.Drawing.Point(592, 353);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(107, 29);
            this.moveRightButton.TabIndex = 16;
            this.moveRightButton.Text = ">";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Location = new System.Drawing.Point(592, 388);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(107, 29);
            this.moveLeftButton.TabIndex = 17;
            this.moveLeftButton.Text = "<";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // generateReportsListing
            // 
            this.generateReportsListing.BackColor = System.Drawing.SystemColors.Control;
            this.generateReportsListing.FormattingEnabled = true;
            this.generateReportsListing.Location = new System.Drawing.Point(845, 231);
            this.generateReportsListing.Name = "generateReportsListing";
            this.generateReportsListing.Size = new System.Drawing.Size(238, 394);
            this.generateReportsListing.TabIndex = 18;
            // 
            // listingLabel
            // 
            this.listingLabel.AutoSize = true;
            this.listingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listingLabel.Location = new System.Drawing.Point(260, 208);
            this.listingLabel.Name = "listingLabel";
            this.listingLabel.Size = new System.Drawing.Size(116, 20);
            this.listingLabel.TabIndex = 19;
            this.listingLabel.Text = "List Of Reports";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(900, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Generate Reports";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(592, 423);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(107, 29);
            this.generateButton.TabIndex = 21;
            this.generateButton.Text = "Generate Reports";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // ReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listingLabel);
            this.Controls.Add(this.generateReportsListing);
            this.Controls.Add(this.moveLeftButton);
            this.Controls.Add(this.moveRightButton);
            this.Controls.Add(this.reportListing);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportUI";
            this.Text = "Reports";
            this.Controls.SetChildIndex(this.titleOfDataLabel, 0);
            this.Controls.SetChildIndex(this.reportListing, 0);
            this.Controls.SetChildIndex(this.moveRightButton, 0);
            this.Controls.SetChildIndex(this.moveLeftButton, 0);
            this.Controls.SetChildIndex(this.generateReportsListing, 0);
            this.Controls.SetChildIndex(this.listingLabel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.generateButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox reportListing;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.ListBox generateReportsListing;
        private System.Windows.Forms.Label listingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateButton;
    }
}