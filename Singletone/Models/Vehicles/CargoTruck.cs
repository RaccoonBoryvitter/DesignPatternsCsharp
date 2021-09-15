using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Models.Vehicles
{
    internal class CargoTruck : CargoVehicle
    {
        public CargoTruck(string name, CargoType cargoType, double weight)
            : base(name, cargoType, weight) { }

        internal override string GetInfo()
        {
            string info = " - Truck ID: " + Id + ";\n"
                + " - Truck Name: " + Name + ";\n"
                + " - Cargo Type: " + CargoType + ";\n"
                + " - Weight: " + Weight + ";\n";

            return info;
        }
    }
}
