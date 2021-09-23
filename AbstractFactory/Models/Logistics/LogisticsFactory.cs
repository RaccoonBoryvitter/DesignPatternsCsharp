using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Models.Logistics
{
    internal abstract class LogisticsFactory
    {
        public List<ITransport> Trucks { get; set; } = new List<ITransport>();
        public List<ITransport> Ships { get; set; } = new List<ITransport>();

        public string RegisterNewTruck()
        {
            ITransport vehicle = CreateNewTruck();
            vehicle.Rfid = Guid.NewGuid().ToString();
            vehicle.IsInTheWay = false;
            Trucks.Add(vehicle);
            return $"A new regular vehicle #{vehicle.Rfid} has been registered.";
        }

        public string RegisterNewShip()
        {
            ITransport vehicle = CreateNewShip();
            vehicle.Rfid = Guid.NewGuid().ToString();
            vehicle.IsInTheWay = false;
            Ships.Add(vehicle);
            return $"A new urgent vehicle #{vehicle.Rfid} has been registered.";
        }

        public abstract ITransport CreateNewTruck();
        public abstract ITransport CreateNewShip();
    }
}
