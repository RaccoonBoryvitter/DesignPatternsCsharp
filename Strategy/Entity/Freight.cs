using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Entity
{
    internal class Freight
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public double Weight { get; set; }

        public string Description { get; set; }
    }
}
