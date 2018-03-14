using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.IO;

namespace FileWorker
{
    class Program
    {
        static void Main(string[] args)
        {
             /*string connectionString = "Server=localhost;UID=root;password=root;database=database_laboratorni";
             DataTable dt = new DataTable();
             dt.Columns.Add(new DataColumn("id", typeof(int)));
             dt.Columns.Add(new DataColumn("name", typeof(string)));
             dt.Columns.Add(new DataColumn("surname", typeof(string)));
             dt.Columns.Add(new DataColumn("age", typeof(int)));
             dt.Columns.Add(new DataColumn("email", typeof(string)));
             var data = Directory.EnumerateFiles(@"C:\с# learning\units,orders,people\FileWorker\FileWorker\","*.txt", SearchOption.TopDirectoryOnly).Select(File.ReadAllText);
             foreach(var v in data)
             {
                 foreach (var s in v.Split('\n'))
                 {
                     var ss = s.Split();
                     DataRow nr = dt.NewRow();
                     nr[0] = Convert.ToInt32(ss[0]);
                     nr[1] = Convert.ToString(ss[1]);
                     nr[2] = Convert.ToString(ss[2]);
                     nr[3] = Convert.ToInt32(ss[3]);
                     nr[4] = Convert.ToString(ss[4]);
                     //nr[2] = ss[2];
                     dt.Rows.Add(nr);
                 }
             }
             using (MySqlConnection connection = new MySqlConnection(connectionString))
             {
                 connection.Open();
                 Console.WriteLine("Подключение открыто");
                 //MySqlCommand command = new MySqlCommand(sqlExpression, connection);
                 //command.ExecuteNonQuery();
                 MySqlDataAdapter ada = new MySqlDataAdapter();
                 ada.InsertCommand = new MySqlCommand("INSERT INTO people VALUES(@id, @name, @surname, @age, @email)", connection);
                 ada.InsertCommand.Parameters.Add("@id", MySqlDbType.Int32).SourceColumn = "id";
                 ada.InsertCommand.Parameters.Add("@name", MySqlDbType.VarChar).SourceColumn = "name";
                 ada.InsertCommand.Parameters.Add("@surname", MySqlDbType.VarChar).SourceColumn = "surname";
                 ada.InsertCommand.Parameters.Add("@age", MySqlDbType.Int32).SourceColumn = "age";
                 ada.InsertCommand.Parameters.Add("@email", MySqlDbType.VarChar).SourceColumn = "email";


                 ada.Update(dt);





             }

             Console.WriteLine("Подключение закрыто...");*/
            var fileManager = new FileManager();
            var dbManager = new DBManager();
            //var person = fileManager.ReadPersonFromFile(FilePaths.PathToPerson);
            //var unit = fileManager.ReadUnitsFromFile(FilePaths.pathToUnits);
            var order = fileManager.ReadOrdersFromFile(FilePaths.PathToOrders);
            
            //dbManager.AddPersonToDB(person);
            //dbManager.AddUnitToDB(unit);

            Console.ReadKey(true);
        }
    }
}
