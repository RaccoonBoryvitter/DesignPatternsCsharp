using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Entity
{
    internal class Freight
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public double Weight { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return $" - ID: {Id};\n" +
                   $" - Weight: {Weight};\n" +
                   $" - Description: {Description};\n";
        }
    }
}
