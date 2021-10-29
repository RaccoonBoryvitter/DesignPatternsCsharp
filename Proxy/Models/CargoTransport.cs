using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Models
{
    internal class CargoTransport
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public double MaxSpeed { get; set; }

        public double FuelCapacity { get; set; }

        public override string ToString()
        {
            return $"Transport #{Id}: \n"
                + $" - Name: {Name}, \n"
                + $" - Max Speed: {MaxSpeed}, \n"
                + $" - Fuel Capacity: {FuelCapacity}.";
        }
    }
}
