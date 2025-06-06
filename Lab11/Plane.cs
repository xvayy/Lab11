using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Plane : Vehicle
    {
        public double Height { get; set; }
        public int PassengerCount { get; set; }

        public Plane(double price, double speed, int year, double height, int passengers)
            : base(price, speed, year)
        {
            Height = height;
            PassengerCount = passengers;
        }

        public override string GetInfo()
        {
            return $"✈️ Plane\n" +
                   $"  • Price: {Price}$\n" +
                   $"  • Speed: {Speed} km/h\n" +
                   $"  • Year: {Year}\n" +
                   $"  • Height: {Height} m\n" +
                   $"  • Passengers: {PassengerCount}";
        }

    }
}
