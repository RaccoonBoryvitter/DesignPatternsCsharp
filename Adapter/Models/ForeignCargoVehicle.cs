using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Models
{
    internal class ForeignCargoVehicle
    {
        public Guid Rfid { get; set; }

        public void Deliver(ForeignShipment shipment)
        {
            Console.WriteLine("\n/////////////////////////////////");
            Console.WriteLine("A foreign shipment has been delivered to custody!");
            Console.WriteLine(shipment.GetInfo());
            Console.WriteLine("/////////////////////////////////\n");
        }
    }
}
