using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    internal class Freight
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public double Weight { get; set; }

        public MaterialType MaterialType { get; set; }

        public SecurityType SecurityType { get; set; }

        public string Description { get; set; }


    }
}
