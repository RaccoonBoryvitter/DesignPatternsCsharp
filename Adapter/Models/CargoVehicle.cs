using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Models
{
    internal class CargoVehicle
    {
        public Guid Rfid { get; set; }

        public void ForeignDeliver(ForeignShipment shipment)
        {
            Console.WriteLine("\n/////////////////////////////////");
            Console.WriteLine("A foreign shipment has been delivered to custody!");
            Console.WriteLine(shipment.GetInfo());
            Console.WriteLine("/////////////////////////////////\n");
        }

        public void LocalDeliver(Freight freight)
        {
            Console.WriteLine("\n/////////////////////////////////");
            Console.WriteLine("Delivering freight in local area...");
            Console.WriteLine(freight.GetInfo());
            Console.WriteLine("/////////////////////////////////\n");
        }
    }
}
