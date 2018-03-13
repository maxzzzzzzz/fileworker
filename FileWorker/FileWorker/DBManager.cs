using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;

namespace FileWorker
{
    class DBManager
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=WHO-PC;Initial Catalog=mydb;Integrated Security=True;Pooling=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Connection Open");
                connection.Open();
                return connection;
            }
           
        }
        public void AddPersonToDB(DataTable dt)
        {
            string connectionString = "Data Source=WHO-PC;Initial Catalog=mydb;Integrated Security=True;Pooling=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Connection Open");
                connection.Open();
                SqlDataAdapter ada = new SqlDataAdapter();
                ada.InsertCommand = new SqlCommand("INSERT INTO person VALUES(@name, @surname, @age, @email)", connection);
                ada.InsertCommand.Parameters.Add("@name", SqlDbType.VarChar).SourceColumn = "name";
                ada.InsertCommand.Parameters.Add("@surname", SqlDbType.VarChar).SourceColumn = "surname";
                ada.InsertCommand.Parameters.Add("@age", SqlDbType.Int).SourceColumn = "age";
                ada.InsertCommand.Parameters.Add("@email", SqlDbType.VarChar).SourceColumn = "email";


                ada.Update(dt);
                Console.WriteLine("added");
            }
        }
    }
}
