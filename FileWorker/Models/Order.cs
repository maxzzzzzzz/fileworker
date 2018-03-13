using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        public Person Person { get; set; }
        public Unit Unit{get;set;}
        public DateTime Date { get; set; }
        public int ForTime { get; set; }
        public Order() { }
        public Order(Person person, Unit unit, DateTime date, int forTime)
        {
            this.Person = person;
            this.Unit = unit;
            this.Date = date;
            this.ForTime = forTime;
        }
    }
}
