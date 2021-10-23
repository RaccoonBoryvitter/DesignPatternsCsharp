using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    internal class Shipment
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public List<Freight> Freights { get; set; }

        public double Price { get; set; }

        public string DispatchedFrom { get; set; }

        public string Destination { get; set; }
    }
}
