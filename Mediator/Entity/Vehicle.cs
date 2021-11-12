using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Entity
{
    internal class Vehicle
    {
        
        public string Name { get; set; }

        public Driver Driver { get; set; }

        public double WeightCapacity { get; set; }

        public override string ToString()
        {
            return $" - Name: {Name};\n" +
                   $" - Driver: {Driver};\n" +
                   $" - Weight capacity: {WeightCapacity};\n";
        }
    }
}
