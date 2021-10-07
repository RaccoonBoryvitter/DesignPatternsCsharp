using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Models
{
    internal class Passage
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public CargoVehicle Vehicle { get; set; }
        public Freight Freight { get; set; }
        public DateTime DispatchedAt { get; set; }
        public DateTime DeliveredAt { get; set; }


        public Passage(CargoVehicle vehicle, Freight freight, DateTime dispatchedAt, DateTime deliveredAt)
        {
            Vehicle = vehicle;
            Freight = freight;
            DispatchedAt = dispatchedAt;
            DeliveredAt = deliveredAt;
        }

        public virtual void Run()
        {
            Console.WriteLine("///////////////////////////");
            Console.WriteLine($"Dispatching freight at {DispatchedAt}...");
            Vehicle.Deliver(Freight);
            Console.WriteLine($"The freight has been delivered at {DeliveredAt}!");
            Console.WriteLine("///////////////////////////");
        }
    }
}
