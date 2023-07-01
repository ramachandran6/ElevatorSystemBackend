using ES.Model;
using Microsoft.Data.SqlClient;
using System.Xml.Schema;

namespace ES.DataAccess
{
    public class DataPerson
    {
        private string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ElevatorSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public bool addPerson(ModelPerson mp)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string query = $"INSERT INTO personTable (person,weight) VALUES({mp.person},{mp.weight})";

            SqlCommand command = new SqlCommand(query, conn);
            command.CommandText = query;
            command.Connection = conn;
            command.CommandType = System.Data.CommandType.Text;

            int resultsAffected = command.ExecuteNonQuery();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
           if(resultsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}