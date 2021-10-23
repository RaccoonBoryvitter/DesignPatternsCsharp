using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new RouteFlyweightFactory(
                new Route { From = "Chernivtsi", To = "Khmelnytskyi" },
                new Route { From = "Khmelnytskyi", To = "Chernivtsi" },
                new Route { From = "Lviv", To = "Ternopil" },
                new Route { From = "Ivano-Frankivsk", To = "Chernivtsi" },
                new Route { From = "Uzhgorod", To = "Ivano-Frankivsk" }
            );

            factory.ListFlyweights();

            CreateNewShipment(factory,
                new Shipment
                {
                    Weight = 4342.5245, 
                    Description = "Desc 1", 
                    Route = new Route { From = "Chernivtsi", To = "Khmelnytskyi" }
                }
            );

            CreateNewShipment(factory,
                new Shipment
                {
                    Weight = 3425.3243,
                    Description = "Desc 1",
                    Route = new Route { From = "Ternopil", To = "Lviv" }
                }
            );

        }

        private static void CreateNewShipment(RouteFlyweightFactory factory, Shipment shipment)
        {
            Console.WriteLine("Client: Creating new shipment object...");

            var flyweight = factory.GetFlyweight(
                new Route
                {
                    From = shipment.Route.From,
                    To = shipment.Route.To
                }
            );

            flyweight.ShowSharedAndUniqueStates(shipment);
        }
    }
}
