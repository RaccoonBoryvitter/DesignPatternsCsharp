using System;

namespace Command
{
    internal class Application
    {
        static void Main(string[] args)
        {
            Warehouse warehouse = new Warehouse();
            Freight freight = new Freight
            {
                Weight = 4325.52,
                Description = "Lorem ipsum tra-ta-ta"
            };
            CargoVehicle vehicle = new CargoVehicle
            {
                WeightCapacity = 5600.0,
                MaxSpeed = 150
            };

            warehouse.OnDayStart = new GenerateReportCommand(freight);
            warehouse.OnDayFinish = new DispatchCommand(vehicle, freight, "Chernivtsi");

            warehouse.ProcessDayWork();
        }
    }
}
