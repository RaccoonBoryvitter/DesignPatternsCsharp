using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Entity
{
    internal class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Client Client { get; set; }

        public Freight Freight { get; set; }

        public string Destination { get; set; }

        public Vehicle Vehicle { get; set; }

        public void Dispatch()
        {
            Console.WriteLine($"Dispatching order #{Id}");
            Vehicle.DispatchTo(Destination);
        }
    }
}
