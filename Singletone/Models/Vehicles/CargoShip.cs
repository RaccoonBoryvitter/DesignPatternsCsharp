using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Models.Vehicles
{
    internal class CargoShip : CargoVehicle
    {
        public CargoShip(string name, CargoType cargoType, double weight)
            : base(name, cargoType, weight) { }

        internal override string GetInfo()
        {
            string info = " - Ship ID: " + Id + ";\n"
                + " - Ship Name: " + Name + ";\n"
                + " - Cargo Type: " + CargoType + ";\n"
                + " - Weight: " + Weight + ";\n";

            return info;
        }
    }
}
