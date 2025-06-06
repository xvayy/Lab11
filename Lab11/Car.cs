using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Car : Vehicle
    {
        public string FuelType { get; set; }

        public Car(double price, double speed, int year, string fuelType)
            : base(price, speed, year)
        {
            FuelType = fuelType;
        }

        public override string GetInfo()
        {
            return $"🚗 Car\n" +
                   $"  • Price: {Price}$\n" +
                   $"  • Speed: {Speed} km/h\n" +
                   $"  • Year: {Year}\n" +
                   $"  • Fuel Type: {FuelType}";
        }

    }

}
