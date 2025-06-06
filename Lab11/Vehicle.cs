using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public abstract class Vehicle
    {
        public double Price { get; set; }
        public double Speed { get; set; }
        public int Year { get; set; }

        public Vehicle(double price, double speed, int year)
        {
            Price = price;
            Speed = speed;
            Year = year;
        }

        public abstract string GetInfo();
    }
}
