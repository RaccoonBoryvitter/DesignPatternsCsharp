using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Entities
{
    internal class Freight
    {
        public Guid Id { get; set; }

        public double Weight { get; set; }

        public string Description { get; set; }
    }
}
