using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    internal interface IShipment
    {
        Freight Freight { get; set; }

        void ProcessFreight();
    }
}
