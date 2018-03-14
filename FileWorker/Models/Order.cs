using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        //public Person Person { get; set; }
       // public Unit Unit{get;set;}
        public int PersonId { get; set; }
        public int UnitId { get; set; }
        public DateTime Date { get; set; }
        public int ForTime { get; set; }
        public Order() { }
        public Order(int personId, int unitId, DateTime date, int forTime )
        {
            this.PersonId = personId;
            this.UnitId = unitId;
            this.Date = date;
            this.ForTime = forTime;
        }
        /*public Order(Person person, Unit unit, DateTime date, int forTime)
        {
            this.Person = person;
            this.Unit = unit;
            this.Date = date;
            this.ForTime = forTime;
        }*/
    }
}
