using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    internal class FragileShipmentDecorator : ShipmentDecorator
    {
        public FragileShipmentDecorator(IShipment wrappee, Freight freight) 
            : base(wrappee, freight)
        {
        }

        public override void ProcessFreight()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("This shipment is marked as FRAGILE, so proper instructions should be provided for profitable delivery.");
            Console.ForegroundColor = ConsoleColor.White;
            base.ProcessFreight();
        }
    }
}
