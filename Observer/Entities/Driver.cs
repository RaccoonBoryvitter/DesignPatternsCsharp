using Observer.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Entities
{
    internal class Driver : IObserver
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public byte Age { get; set; }

        public DriverCategory Category { get; set; }

        public Division Division { get; set; }

        public void Update(object data)
        {
            if (!(data is Order))
            {
                Console.WriteLine("I can't handle it, this is not an order.");
                return;
            }

            var order = data as Order;
            Console.WriteLine($"Driver {Name}: I can drive it!");
        }
    }
}
