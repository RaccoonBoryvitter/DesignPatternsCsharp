using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    internal class Shipment
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Freight Freight { get; set; }

        public CargoVehicle Vehicle { get; set; }
    }
}
