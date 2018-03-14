using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set;}
        public string Email { get; set; }
        public Person() { }
        public Person(int id, string name, string surname, int age, string email)
        {
            this.Id = id;
            this.Name= name;
            this.Surname = surname;
            this.Age = age;
            this.Email = email;
        }
        public Person(string name, string surname, int age, string email)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Email = email;
        }
        public void PrintInfo()
        {
            Console.WriteLine(Name + " " + " " + Surname + " " + Age + " " + Email);
        }

    }
}
