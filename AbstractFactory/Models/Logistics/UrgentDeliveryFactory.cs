using AbstractFactory.Models.Transport;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Models.Logistics
{
    internal class UrgentDeliveryFactory : LogisticsFactory
    {
        public override ITransport CreateNewShip()
        {
            return new UrgentShip();
        }

        public override ITransport CreateNewTruck()
        {
            return new UrgentTruck();
        }
    }
}
