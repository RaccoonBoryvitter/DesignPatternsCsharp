using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Models
{
    internal class CargoPlane : CargoVehicle
    {
        public Guid Rfid { get; set; }
        public double Speed { get; set; }

        public CargoPlane(double speed)
        {
            Rfid = Guid.NewGuid();
            Speed = speed;
        }

        public void Deliver(Freight freight)
        {
            Console.WriteLine("Deliver in progress...");
            Console.WriteLine($"Plane ID: {Rfid}");
            Console.WriteLine($"Plane Speed: {Speed}");
        }
    }
}
