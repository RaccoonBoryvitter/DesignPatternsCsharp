using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    internal class Shipment : IShipment
    {
        public Freight Freight { get; set; }

        public void ProcessFreight()
        {
            Console.WriteLine("The freight is ready for shipment and is waiting for dispatch!");
            Console.WriteLine("Shipment info: ");
            Console.WriteLine($" - ID: {Freight.Id}");
            Console.WriteLine($" - Weight: {Freight.Weight}");
            Console.WriteLine($" - Description: {Freight.Description}");
        }
    }
}
