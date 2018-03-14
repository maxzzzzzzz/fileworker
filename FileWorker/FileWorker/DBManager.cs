using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;

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
        public void AddPersonToDB(List<Person> list)
        {
            string connectionString = "Data Source=WHO-PC;Initial Catalog=mydb;Integrated Security=True;Pooling=False";
            
            string insertStmt = "INSERT INTO person(name, surname, age, email) " +
                    "VALUES(@name, @surname, @age, @email)";

            
            using (SqlConnection connection = new SqlConnection(connectionString))
               {
                SqlCommand cmd = new SqlCommand(insertStmt, connection);
                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters.Add("@surname", SqlDbType.VarChar);
                cmd.Parameters.Add("@age", SqlDbType.Int);
                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                connection.Open();
                foreach(var person in list)
                {
                    cmd.Parameters["@name"].Value = person.Name;
                    cmd.Parameters["@surname"].Value = person.Surname;
                    cmd.Parameters["@age"].Value = person.Age;
                    cmd.Parameters["@email"].Value = person.Email;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
               }
        }

        public void AddUnitToDB(List<Unit> list)
        {
            string connectionString = "Data Source=WHO-PC;Initial Catalog=mydb;Integrated Security=True;Pooling=False";

            string insertStmt = "INSERT INTO unit(typeOfUnit, area, price) " +
                    "VALUES(@typeOfUnit, @area, @price)";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(insertStmt, connection);
                cmd.Parameters.Add("@typeOfUnit", SqlDbType.VarChar);
                cmd.Parameters.Add("@area", SqlDbType.Float);
                cmd.Parameters.Add("@price", SqlDbType.Decimal);
                connection.Open();
                foreach (var unit in list)
                {
                    cmd.Parameters["@typeOfUnit"].Value = unit.TypeOfUnit;
                    cmd.Parameters["@area"].Value = unit.Area;
                    cmd.Parameters["@price"].Value = unit.Price;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}


