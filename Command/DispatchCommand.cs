using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    internal class DispatchCommand : ICommand
    {
        public CargoVehicle Vehicle { get; set; }

        public Freight Freight { get; set; }

        public string DispatchPoint { get; set; }

        public DispatchCommand(CargoVehicle vehicle, Freight freight, string dispatchPoint)
        {
            Vehicle = vehicle;
            Freight = freight;
            DispatchPoint = dispatchPoint;
        }

        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Executing dispatch command");
            Console.WriteLine(Vehicle.LoadFreight(Freight));
            Console.WriteLine(Vehicle.DispatchTo(DispatchPoint));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
