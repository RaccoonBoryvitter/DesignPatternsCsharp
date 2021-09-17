using AbstractFactory.Models.Transport;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Models.Logistics
{
    internal class ShipFactory : LogisticsFactory
    {
        public override ITransport CreateRegularVehicle()
        {
            return new RegularShip();
        }

        public override ITransport CreateUrgentVehicle()
        {
            return new UrgentShip();
        }
    }
}
