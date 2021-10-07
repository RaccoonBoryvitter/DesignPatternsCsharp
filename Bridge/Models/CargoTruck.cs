using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Models
{
    internal class CargoTruck : CargoVehicle
    {
        public Guid Rfid { get; set; }
        public double Speed { get; set; }

        public CargoTruck(double speed)
        {
            Rfid = Guid.NewGuid();
            Speed = speed;
        }

        public void Deliver(Freight freight)
        {
            Console.WriteLine("Deliver in progress...");
            Console.WriteLine($"Truck ID: {Rfid}");
            Console.WriteLine($"Truck Spped: {Speed}");
        }
    }
}
