using System;
using System.Collections.Generic;
using System.Linq;

namespace Decorator
{
    internal class Application
    {
        static void Main(string[] args)
        {
            Freight[] freights = new Freight[]
            {
                new Freight
                {
                    Weight = 432.62,
                    Description = "Desc 1",
                    Type = FreightType.Simple,
                    SecurityType = SecurityType.Safe,
                },
                new Freight
                {
                    Weight = 213.52,
                    Description = "Desc 2",
                    Type = FreightType.Liquid,
                    SecurityType = SecurityType.Safe,
                },
                new Freight
                {
                    Weight = 943.413,
                    Description = "Desc 3",
                    Type = FreightType.Fragile,
                    SecurityType = SecurityType.Dangerous,
                },
                new Freight
                {
                    Weight = 652.523,
                    Description = "Desc 4",
                    Type = FreightType.Liquid,
                    SecurityType = SecurityType.Dangerous,
                },
            };

            IShipment[] shipments = freights.Select(f => new Shipment { Freight = f }).ToArray();
            var processedShipments = Client.ConfigureShipments(shipments);
            foreach (var shipment in processedShipments)
            {
                shipment.ProcessFreight();
                Console.WriteLine();
            }
        }
    }
}
