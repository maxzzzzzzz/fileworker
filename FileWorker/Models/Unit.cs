using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Unit
    {
        public string TypeOfUnit { get; set; }
        public double Area { get; set; }
        public decimal Price{ get; set; }
        public Unit(){}
        public Unit(string typeOfUnit, double area, decimal price)
        {
            this.TypeOfUnit = typeOfUnit;
            this.Area = area;
            this.Price = price;
        }
    }
}
