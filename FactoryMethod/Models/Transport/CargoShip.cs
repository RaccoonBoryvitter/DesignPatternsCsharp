using System;
using System.Threading;

using FactoryMethod.Helpers;

namespace FactoryMethod.Models.Transport
{
    internal class CargoShip : CargoVehicle
    {
        public string Rfid { get; set; }
        public double WeightCapacity { get; set; } = new Random().NextDouble() * 30.0 + 15.0;
        public DateTime LifeTime { get; set; } = DateRangePicker.PickBetween("01-01-2023", "31-12-2045");
        public bool IsInTheWay { get; set; }

        public void Deliver(Freight freight)
        {
            Thread.Sleep(500);
            Console.WriteLine($"\nA freight #{freight.Id} has been delivered successfully from {freight.From} to {freight.To} by ship.\n");
        }
    }
}
