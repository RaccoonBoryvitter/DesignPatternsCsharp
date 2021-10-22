using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    internal class LiquidShipmentDecorator : ShipmentDecorator
    {
        public LiquidShipmentDecorator(IShipment wrappee, Freight freight) 
            : base(wrappee, freight)
        {
        }

        public override void ProcessFreight()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("This shipment is marked as LIQUID, so proper instructions should be provided for profitable delivery.");
            Console.ForegroundColor = ConsoleColor.White;
            base.ProcessFreight();
        }
    }
}
