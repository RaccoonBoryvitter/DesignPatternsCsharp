using System;
using AbstractFactory.Models.Transport;

namespace AbstractFactory.Models.Logistics
{
    internal class RegularDeliveryFactory : LogisticsFactory
    {
        public override ITransport CreateNewShip()
        {
            return new RegularShip();
        }

        public override ITransport CreateNewTruck()
        {
            return new RegularTruck();
        }
    }
}
