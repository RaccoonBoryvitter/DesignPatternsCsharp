using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Models.Vehicles
{
    internal abstract class CargoVehicle
    {
        internal string Id { get; }
        internal string Name { get; set; }
        internal CargoType CargoType { get; set; }
        internal double Weight { get; set; }

        internal CargoVehicle(string name, CargoType cargoType, double weight)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            CargoType = cargoType;
            Weight = weight;
        }

        internal abstract string GetInfo();
    }
}
