using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SDSU_Rock_Wall_CRM
{
    public partial class InventoryUI : BasicLayout
    {
        public InventoryUI()
        {
            InitializeComponent();
        }

        private void InventoryUI_Load(object sender, EventArgs e)
        {
            var inventory = new Inventory();
            dataGridView1.DataSource = inventory.displayInventory(dataGridView1);
            dataGridView1.Columns[0].HeaderText = "Item Name";
            dataGridView1.Columns[1].HeaderText = "ID";
            dataGridView1.Columns[2].HeaderText = "Purchase Date";
            dataGridView1.Columns[3].HeaderText = "Replacement Date";
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void inventoryUpdateButton_Click(object sender, EventArgs e)
        {
            if (isDuplicates() == true)
            {
                MessageBox.Show("Error: There is a duplicate ID in inventory table. Fix the ID before updating your inventory.");
            }
            else
            {
                Database db = new Database();
                SqlCommand command = new SqlCommand("Select * From Inventory", db.con);
                DataSet oldTable = db.sendSelectCommand(command);
                int i = 0;
                while (i < oldTable.Tables[0].Rows.Count)
                {
                    if (containsID(dataGridView1, oldTable.Tables[0].Rows[i][1].ToString()) == false)
                    {
                        command.CommandText = "Delete From Inventory Where id=@oldID";
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@oldID", oldTable.Tables[0].Rows[i][1]);
                        db.sendDeleteCommand(command);
                    }
                    i++;
                }
                i = 0;
                while (i < dataGridView1.Rows.Count - 1)
                {
                    if (containsID(oldTable, dataGridView1.Rows[i].Cells[1]) == true)
                    {
                        command.CommandText = "Update Inventory Set item=@item,id=@id,purchaseDate=@purchaseDate,replacementDate=@replacementDate Where id=@updateID";
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@item", dataGridView1.Rows[i].Cells[0].Value.ToString());
                        command.Parameters.AddWithValue("@id", dataGridView1.Rows[i].Cells[1].Value.ToString());
                        command.Parameters.AddWithValue("@purchaseDate", dataGridView1.Rows[i].Cells[2].Value.ToString());
                        command.Parameters.AddWithValue("@replacementDate", dataGridView1.Rows[i].Cells[3].Value.ToString());
                        command.Parameters.AddWithValue("@updateID", dataGridView1.Rows[i].Cells[1].Value.ToString());
                        db.sendUpdateCommand(command);
                    }
                    else if (containsID(oldTable, dataGridView1.Rows[i].Cells[1]) == false)
                    {
                        Inventory inventory = new Inventory();
                        inventory.insertInventoryItem(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString()), Convert.ToDateTime(dataGridView1.Rows[i].Cells[2].Value.ToString()), Convert.ToDateTime(dataGridView1.Rows[i].Cells[3].Value.ToString()));
                    }
                    i++;
                }
            }
        }
        private bool isDuplicates()
        {
            List<int> masterList = new List<int>();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (masterList.Contains(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString()))){
                    return true;
                }
                else
                {
                    masterList.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString()));
                }
            }
            return false;
        }
        private bool containsID(DataSet ds, DataGridViewCell c)
        {
            int i = 0;
            while(i < ds.Tables[0].Rows.Count)
            {
                if(ds.Tables[0].Rows[i][1].ToString() == c.Value.ToString())
                {
                    return true;
                }
                i++;
            }
            return false;
        }
        private bool containsID(DataGridView table, String c)
        {
            int i = 0;
            while (i < table.Rows.Count-1)
            {
                if(table.Rows[i].Cells[1].Value.ToString() == c.ToString())
                {
                    return true;
                }
                i++;
            }
            return false;
        }
    }
}
