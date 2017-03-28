using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SDSU_Rock_Wall_CRM
{
    class Database
    {
        private const string connectionString = "Data Source = sqlpiedpiper.database.windows.net; Initial Catalog=RockWallSDSU; Persist Security Info = True; User ID = devadmin; Password = P@ssword";
        public SqlConnection con { get; private set; }
        private SqlDataAdapter adapt; 

        public Database()
        {
            con = new SqlConnection(connectionString);
        }
        public MemoryStream getImage(string firstName, string lastName, string dateOfBirth)
        {
            Database db = new Database();
            SqlCommand command = new SqlCommand("Select image From Waiver Where userID = (Select id From Patrons Where firstName=@fName And lastName=@lName And dateOfBirth=@DOB)", db.con);
            DataSet result = db.sendSelectCommand(command);
            MemoryStream ms = new MemoryStream((byte[])result.Tables[0].Rows[0][0]);
            return ms;
        }
        public DataSet sendSelectCommand(SqlCommand command)
        {
            DataSet returnedData = new DataSet();
            con.Open();
            adapt = new SqlDataAdapter(command);
            adapt.SelectCommand = command;
            adapt.Fill(returnedData);
            con.Close();
            return returnedData;
        }

        public void sendInsertCommand(SqlCommand command)
        {
            command.Connection = con;
            command.CommandType = CommandType.Text;
            try
            {
                con.Open();
                int recordsAffected = command.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return;
        }

        public void sendDeleteCommand(SqlCommand command)
        {
            command.Connection = con;
            command.CommandType = CommandType.Text;
            try
            {
                con.Open();
                int recordsAffected = command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return;
        }

        public void sendUpdateCommand(SqlCommand command)
        {
            command.Connection = con;
            command.CommandType = CommandType.Text;
            try
            {
                con.Open();
                int recordsAffected = command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return;
        }
    }
}
