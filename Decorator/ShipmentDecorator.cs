using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    internal class ShipmentDecorator : IShipment
    {
        public IShipment Wrappee { get; set; }
        public Freight Freight { get; set; }

        public ShipmentDecorator(IShipment wrappee, Freight freight)
        {
            Wrappee = wrappee;
            Freight = freight;
            Wrappee.Freight = Freight;
        }

        public virtual void ProcessFreight()
        {
            Wrappee.ProcessFreight();
        }
    }
}
