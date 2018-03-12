using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWorker
{
    class People
    {
        int id;
        string name;
        string surname;
        int age;
        string email;
        public People() { }
        public People(int _id,string _name,string _surname, int _age, string _email)
        {
            id = _id;
            name = _name;
            surname = _surname;
            age = _age;
            email = _email;
        }
    }
}
