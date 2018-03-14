using System;
using FileWorker.Interfaces;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
namespace FileWorker
{
    class FileManager : IFileManager
    {
        public List<Person> ReadPersonFromFile(String pathName)
        {
            IEnumerable<string> text = File.ReadLines(pathName);
            List<Person> persons = new List<Person>();
            var person = new Person();
            
            foreach(var s in text)
            {
                foreach(var v in s.Split('\n'))
                {
                    var ss = s.Split();
                    var per = new Person();
                    per.Name = Convert.ToString(ss[0]);
                    per.Surname = Convert.ToString(ss[1]);
                    per.Age = Convert.ToInt32(ss[2]);
                    per.Email = Convert.ToString(ss[3]);

                    persons.Add(per);
                }
            }
    
            return persons;
        }


          public List<Unit> ReadUnitsFromFile(string pathName)
        {
            IEnumerable<string> text = File.ReadLines(pathName);
            List<Unit> units = new List<Unit>();
            

            foreach (var s in text)
            {
                foreach (var v in s.Split('\n'))
                {
                    var ss = s.Split();
                    var unit = new Unit();
                    unit.TypeOfUnit = Convert.ToString(ss[0]);
                    unit.Area = Convert.ToDouble(ss[1]);
                    unit.Price = Convert.ToDecimal(ss[2]);
                    

                    units.Add(unit);
                }
            }

            return units;
        }
          public List<Order> ReadOrdersFromFile(string pathName)
            {
            IEnumerable<string> text = File.ReadAllLines(pathName);
            List<Order> orders = new List<Order>();
            char[] del = { ' ' };
            

            foreach (var s in text)
            {
                foreach (var v in s.Split(del))
                {
                    var ss = s.Split();
                    var order = new Order();
                    order.PersonId = Convert.ToInt32(ss[0]);
                    order.UnitId = Convert.ToInt32(ss[1]);
                    order.Date = Convert.ToDateTime((ss[2]));
                    order.ForTime = Convert.ToInt32(ss[3]);
                    orders.Add(order);
                }
            }

            return orders;
        }
    }   
}


    

