namespace SDSU_Rock_Wall_CRM
{
    partial class InventoryUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryUI));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inventoryUpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleOfDataLabel
            // 
            this.titleOfDataLabel.Size = new System.Drawing.Size(118, 29);
            this.titleOfDataLabel.Text = "Inventory";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1213, 494);
            this.dataGridView1.TabIndex = 15;
            // 
            // inventoryUpdateButton
            // 
            this.inventoryUpdateButton.Location = new System.Drawing.Point(1132, 146);
            this.inventoryUpdateButton.Name = "inventoryUpdateButton";
            this.inventoryUpdateButton.Size = new System.Drawing.Size(105, 23);
            this.inventoryUpdateButton.TabIndex = 16;
            this.inventoryUpdateButton.Text = "Update Inventory";
            this.inventoryUpdateButton.UseVisualStyleBackColor = true;
            this.inventoryUpdateButton.Click += new System.EventHandler(this.inventoryUpdateButton_Click);
            // 
            // InventoryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.inventoryUpdateButton);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryUI";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.InventoryUI_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.inventoryUpdateButton, 0);
            this.Controls.SetChildIndex(this.titleOfDataLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button inventoryUpdateButton;
    }
}