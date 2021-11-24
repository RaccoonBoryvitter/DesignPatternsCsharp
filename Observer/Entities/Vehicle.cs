using Observer.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Entities
{
    internal class Vehicle : IObserver
    {
        public Guid Id { get; set; }

        public string LicensePlate { get; set; }

        public double WeightCapacity { get; set; }

        public Driver Driver { get; set; }

        public Division Division { get; set; }

        public void Update(object data)
        {
            if (!(data is Order))
            {
                Console.WriteLine("I can't handle it, this is not an order.");
                return;
            }

            var order = data as Order;
            if (order.Freight.Weight <= WeightCapacity)
            {
                Console.WriteLine($"Vehicle {LicensePlate}: Ok, I can move it on my fours.");
            }
            else
            {
                Console.WriteLine($"Vehicle {LicensePlate}: No, it's too fat for me.");
            }
        }
    }
}
