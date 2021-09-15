using Singleton.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Models.Posts
{
    internal class DispatchPost : IPost
    {
        public string Id { get; }

        public DailyStatistics Statistics { get; }

        public DispatchPost(DailyStatistics statistics)
        {
            Id = Guid.NewGuid().ToString();
            Statistics = statistics;
        }

        public void ProcessCargo(CargoVehicle vehicle)
        {
            Statistics.IncrementDispatchesAmount();
            Statistics.IncreaseDispatchesWeight(vehicle.Weight);
            string logInfo = "========================== INFO BLOCK ==========================\n"
                    + "The cargo has been dispatched successfully from #" + Id + ".\n"
                    + "Vehicle Info: \n"
                    + vehicle.GetInfo()
                    + "Information has been noted to statistics.\n"
                    + "================================================================\n";

            Console.WriteLine(logInfo);
        }
    }
}
