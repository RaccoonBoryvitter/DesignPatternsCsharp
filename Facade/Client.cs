using Facade.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    internal class Client
    {
        public void GenerateReports(IEnumerable<Shipment> shipments)
        {
            AmericanShipmentSerializer serializer = new AmericanShipmentSerializer(
                new MassConverter(), new CurrencyConverter());
            foreach (var shipment in shipments)
            {
                serializer.GenerateJson(shipment);
            }
        }
    }
}
