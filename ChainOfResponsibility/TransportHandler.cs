using System;
using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibility
{
    internal class TransportHandler : AbstractHandler
    {
        public List<CargoVehicle> Vehicles { get; }

        public TransportHandler(List<CargoVehicle> vehicles)
        {
            Vehicles = vehicles.OrderBy(v => v.WeightCapacity).ToList();
        }

        public override object Handle(object request)
        {
            if(request is Freight)
            {
                var freight = request as Freight;
                var vehicle = Vehicles.FirstOrDefault(v => freight.Weight <= v.WeightCapacity);
                if (vehicle == null)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"There is no transport for freight {freight.Id}, so it's not dispatched.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();

                    return null;
                }

                Vehicles.Remove(vehicle);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Freight {freight.Id} is loaded to transport and ready to dispatch.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                return new Shipment
                {
                    Freight = freight,
                    Vehicle = vehicle
                };
            }

            return base.Handle(request);
        }
    }
}
