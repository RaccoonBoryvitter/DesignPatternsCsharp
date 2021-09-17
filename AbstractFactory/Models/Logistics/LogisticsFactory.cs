using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Models.Logistics
{
    internal abstract class LogisticsFactory
    {
        public List<ITransport> RegularVehicles { get; set; } = new List<ITransport>();
        public List<ITransport> UrgentVehicles { get; set; } = new List<ITransport>();

        public string RegisterNewRegularVehicle()
        {
            ITransport vehicle = CreateRegularVehicle();
            vehicle.Rfid = Guid.NewGuid().ToString();
            vehicle.IsInTheWay = false;
            RegularVehicles.Add(vehicle);
            return $"A new regular vehicle #{vehicle.Rfid} has been registered.";
        }

        public string RegisterNewUrgentVehicle()
        {
            ITransport vehicle = CreateUrgentVehicle();
            vehicle.Rfid = Guid.NewGuid().ToString();
            vehicle.IsInTheWay = false;
            UrgentVehicles.Add(vehicle);
            return $"A new urgent vehicle #{vehicle.Rfid} has been registered.";
        }

        public abstract ITransport CreateRegularVehicle();
        public abstract ITransport CreateUrgentVehicle();
    }
}
