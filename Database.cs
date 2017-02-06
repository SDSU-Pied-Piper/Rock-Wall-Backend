using System.Data;
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
