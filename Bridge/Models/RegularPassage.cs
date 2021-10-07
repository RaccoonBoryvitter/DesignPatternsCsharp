using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Models
{
    internal class RegularPassage : Passage
    {
        public RegularPassage(
            CargoVehicle vehicle, 
            Freight freight, 
            DateTime dispatchedAt, 
            DateTime deliveredAt
        ) : base(vehicle, freight, dispatchedAt, deliveredAt) { }

        public override void Run()
        {
            Console.WriteLine("///////////////////////////");
            Console.WriteLine($"Dispatching freight at {DispatchedAt}...");
            Vehicle.Deliver(Freight);
            Console.WriteLine($"The freight has been delivered at {DeliveredAt}!");
            DispatchedAt = DispatchedAt.AddDays(3);
            DeliveredAt = DeliveredAt.AddDays(3);
            Console.WriteLine($"The next passage is planned at {DispatchedAt} and must be delivered at {DeliveredAt}");
            Console.WriteLine("///////////////////////////");
        }
    }
}
