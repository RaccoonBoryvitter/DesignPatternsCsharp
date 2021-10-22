using System;
using System.Collections.Generic;
using System.Linq;

namespace Decorator
{
    internal static class Client
    {
        public static IEnumerable<IShipment> ConfigureShipments(IEnumerable<IShipment> shipments)
        {
            var simple = shipments.Where(s => s.Freight.Type == FreightType.Simple)
                                  .ToList();

            var liquid = shipments.Where(s => s.Freight.Type == FreightType.Liquid)
                                  .Select(s => new LiquidShipmentDecorator(s, s.Freight))
                                  .ToList();

            var fragile = shipments.Where(s => s.Freight.Type == FreightType.Fragile)
                                   .Select(s => new FragileShipmentDecorator(s, s.Freight))
                                   .ToList();

            List<IShipment> filteredByFreightType = new List<IShipment>(simple);
            filteredByFreightType.AddRange(liquid);
            filteredByFreightType.AddRange(fragile);

            var safe = filteredByFreightType.Where(s => s.Freight.SecurityType == SecurityType.Safe)
                                            .ToList();

            var dangerous = filteredByFreightType.Where(s => s.Freight.SecurityType == SecurityType.Dangerous)
                                     .Select(s => new DangerShipmentDecorator(s, s.Freight))
                                     .ToList();

            List<IShipment> result = new List<IShipment>(safe);
            result.AddRange(dangerous);

            return result;
        }
    }
}
