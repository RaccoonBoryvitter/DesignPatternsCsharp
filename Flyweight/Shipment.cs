using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    internal class Shipment
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public double Weight { get; set; }

        public string Description { get; set; }

        public Route Route { get; set; }

        public override string ToString()
        {
            string res = $"Shipment #{Id}"
                       + $" - Weight: {Weight}"
                       + $" - Description: {Description}"
                       + $" - Route: from {Route.From} to {Route.To}";

            return res;
        }
    }
}
