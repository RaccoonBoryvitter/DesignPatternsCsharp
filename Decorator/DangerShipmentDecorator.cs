using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    internal class DangerShipmentDecorator : ShipmentDecorator
    {
        public DangerShipmentDecorator(IShipment wrappee, Freight freight) 
            : base(wrappee, freight)
        {
        }

        public override void ProcessFreight()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("WARNING! This shipment is marked as DANGEROUS, so proper instructions should be provided for the safest delivery.");
            Console.ForegroundColor = ConsoleColor.White;
            base.ProcessFreight();
        }
    }
}
