using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Models
{
    internal class LocalCargoVehicle
    {
        public Guid Rfid { get; set; }

        public void Deliver(Freight freight)
        {
            Console.WriteLine("\n/////////////////////////////////");
            Console.WriteLine("Delivering freight in local area...");
            Console.WriteLine(freight.GetInfo());
            Console.WriteLine("/////////////////////////////////\n");
        }
    }
}
