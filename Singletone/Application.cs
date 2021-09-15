using Singleton.Helpers;
using Singleton.Models;
using Singleton.Models.Posts;
using Singleton.Models.Vehicles;
using System;
using System.Collections.Generic;

namespace Singleton
{
    internal class Application
    {
        public static void Main(string[] args)
        {
            List<CargoVehicle> vehicles = new List<CargoVehicle>
            {
                new CargoTruck("Volvo", CargoType.Simple, 16.5),
                new CargoTruck("DAF", CargoType.Fragile, 12.7),
                new CargoShip("Maersk", CargoType.Fragile, 20.3),
                new CargoShip("Evergreen", CargoType.Simple, 25.8)
            };

            List<IPost> posts = new List<IPost>
            {
                new DeliveryPost(DailyStatistics.Instance),
                new DeliveryPost(DailyStatistics.Instance),
                new DeliveryPost(DailyStatistics.Instance),
                new DispatchPost(DailyStatistics.Instance),
                new DispatchPost(DailyStatistics.Instance),
                new DispatchPost(DailyStatistics.Instance)
            };

            ThreadHelper.ProcessThreads(12, vehicles, posts);

            Console.WriteLine("\n\n========================== IN TOTAL ==========================");
            Console.WriteLine(DailyStatistics.Instance.GetInfo());
            DailyStatistics.Instance.Reset();

        }
    }
}
