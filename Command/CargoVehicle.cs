using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    internal class CargoVehicle
    {
        public Guid Rfid { get; set; } = Guid.NewGuid();

        public int MaxSpeed { get; set; }

        public double WeightCapacity { get; set; }

        public string LoadFreight(Freight freight)
        {
            return $"Freight {freight.Id} has been loaded into vehicle {Rfid}";
        }

        public string DispatchTo(string point)
        {
            return $"The freight has been dispatched to {point}.";
        }

    }
}
