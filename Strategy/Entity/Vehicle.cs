using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Entity
{
    internal abstract class Vehicle
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public double WeightCapacity { get; set; }

        public abstract void DispatchTo(string destination);
    }
}
