using System;
using System.Collections.Generic;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Freight> freights1 = new List<Freight>()
            {
                new Freight { Weight = 4324.525, Description = "Desc 1" },
                new Freight { Weight = 255.432, Description = "Desc 2" },
                new Freight { Weight = 423234.5323, Description = "Desc 3" },
            };

            List<Freight> freights2 = new List<Freight>()
            {
                new Freight { Weight = 432.73, Description = "Desc 1" },
                new Freight { Weight = 24.231, Description = "Desc 2" },
            };

            Shipment[] shipments = new Shipment[]
            {
                new Shipment()
                {
                    Freights = freights1,
                    Price = 43152.40,
                    DispatchedFrom = "Khmelnytskyi",
                    Destination = "New-York",
                },

                new Shipment()
                {
                    Freights = freights2,
                    Price = 8141.54,
                    DispatchedFrom = "Chernivtsi",
                    Destination = "Chicago",
                }
            };

            Client client = new Client();
            client.GenerateReports(shipments);
        }
    }
}
