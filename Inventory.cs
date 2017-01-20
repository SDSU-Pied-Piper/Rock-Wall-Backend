using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SDSU_Rock_Wall_CRM
{
    class Inventory
    {
        public Inventory() { }

        public void insertInventoryItem(string item, int id, DateTime purchaseDate, DateTime replacementDate)
        {
            Database db = new Database();
            SqlCommand command = new SqlCommand("Select id from Inventory where id=@id", db.con);
            command.Parameters.AddWithValue("@id", id);
            DataSet returnedData = new DataSet();
            returnedData = db.sendSelectCommand(command);
            string searchExpression = $"Id = {id}";
            if(returnedData.Tables[0].Rows.Count > 0)
            {
                command.CommandText = "Select id from Inventory";
                command.Parameters.Clear();
                returnedData = db.sendSelectCommand(command);              
                int newId = returnedData.Tables[0].Rows.Count + 1;
                MessageBox.Show($"Error: Inventory already has an item with ID: {id}{System.Environment.NewLine} ID for {item} is changed to {newId}.");
                id = newId;
            }
            returnedData.Reset();
            command.Parameters.Clear();
            command.CommandText = "INSERT INTO Inventory VALUES (@item,@id,@purchaseDate,@replacementDate)";
            command.Parameters.AddWithValue("@item", item);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@purchaseDate", purchaseDate.ToShortDateString());
            command.Parameters.AddWithValue("@replacementDate", replacementDate.ToShortDateString());
            db.sendInsertCommand(command);
            //TODO: Check for successful insert
        }
        public void removeInventoryItemById(int id)
        {
            Database db = new Database();
            SqlCommand command = new SqlCommand("DELETE FROM Inventory WHERE id=@id", db.con);
            command.Parameters.AddWithValue("@id", id);
            db.sendDeleteCommand(command);
         }
    }
}
