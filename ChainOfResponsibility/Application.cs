using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    internal class Application
    {
        static void Main(string[] args)
        {
            var freights = new List<Freight>()
            {
                new Freight
                {
                    Weight = 412.53,
                    MaterialType = MaterialType.Simple,
                    SecurityType = SecurityType.Safe,
                    Description = "1"
                },
                new Freight
                {
                    Weight = 234.51,
                    MaterialType = MaterialType.Liquid,
                    SecurityType = SecurityType.Safe,
                    Description = "2"
                },
                new Freight
                {
                    Weight = 865.43,
                    MaterialType = MaterialType.Fragile,
                    SecurityType = SecurityType.Danger,
                    Description = "3"
                },
                new Freight
                {
                    Weight = 565.54,
                    MaterialType = MaterialType.Liquid,
                    SecurityType = SecurityType.Danger,
                    Description = "4"
                },
                new Freight
                {
                    Weight = 75.54,
                    MaterialType = MaterialType.Simple,
                    SecurityType = SecurityType.Danger,
                    Description = "5"
                },
            };

            var vehicles = new List<CargoVehicle>()
            {
                new CargoVehicle
                {
                    MaxSpeed = 120,
                    WeightCapacity = 900.0,
                    Type = VehicleType.Truck,
                },
                new CargoVehicle
                {
                    MaxSpeed = 150,
                    WeightCapacity = 500.0,
                    Type = VehicleType.Ship,
                },
                new CargoVehicle
                {
                    MaxSpeed = 250,
                    WeightCapacity = 300.0,
                    Type = VehicleType.Plane,
                },
                new CargoVehicle
                {
                    MaxSpeed = 180,
                    WeightCapacity = 650.0,
                    Type = VehicleType.Truck,
                },
            };

            var materialHandler = new MaterialHandler();
            var securityHandler = new SecurityHandler();
            var transportHandler = new TransportHandler(vehicles);

            materialHandler.SetNext(securityHandler)
                           .SetNext(transportHandler);

            var warehouse = new Warehouse(freights);
            var shipments = warehouse.ProcessFreights(materialHandler);

            foreach (var shipment in shipments)
            {
                if (shipment != null)
                    Console.WriteLine($"Freight: {shipment.Freight.Weight}, " +
                        $"vehicle speed: {shipment.Vehicle.MaxSpeed}");
            }
        }
    }
}
