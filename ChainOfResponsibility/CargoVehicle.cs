using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    internal class CargoVehicle
    {
        public Guid Rfid { get; set; } = Guid.NewGuid();

        public VehicleType Type { get; set; }

        public int MaxSpeed { get; set; }

        public double WeightCapacity { get; set; }
        
    }
}
