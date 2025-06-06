using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Ship : Vehicle
    {
        public int PassengerCount { get; set; }
        public string Port { get; set; }

        public Ship(double price, double speed, int year, int passengers, string port)
            : base(price, speed, year)
        {
            PassengerCount = passengers;
            Port = port;
        }

        public override string GetInfo()
        {
            return $"🚢 Ship\n" +
                   $"  • Price: {Price}$\n" +
                   $"  • Speed: {Speed} km/h\n" +
                   $"  • Year: {Year}\n" +
                   $"  • Port: {Port}\n" +
                   $"  • Passengers: {PassengerCount}";
        }
    }

}
