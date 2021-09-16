using FactoryMethod.Models.Transport;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Models.Logistics
{
    internal abstract class LogisticsDepartment
    {
        public List<CargoVehicle> Vehicles { get; set; } = new List<CargoVehicle>();
        public string RegisterNewVehicle()
        {
            CargoVehicle vehicle = CreateVehicle();
            vehicle.Rfid = Guid.NewGuid().ToString();
            vehicle.IsInTheWay = false;
            Vehicles.Add(vehicle);
            return $"A new vehicle #{vehicle.Rfid} has been registered.";
        }

        public abstract CargoVehicle CreateVehicle();
    }
}
