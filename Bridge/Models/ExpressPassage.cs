using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Models
{
    internal class ExpressPassage : Passage
    {
        public ExpressPassage(
            CargoVehicle vehicle,
            Freight freight,
            DateTime dispatchedAt,
            DateTime deliveredAt
        ) : base(vehicle, freight, dispatchedAt, deliveredAt) { }

        public override void Run()
        {
            Console.WriteLine("///////////////////////////");
            Console.WriteLine("This passage is express and the vehicle should speed up to make it quickly!");

            TimeSpan previous = DeliveredAt.Subtract(DispatchedAt);
            DeliveredAt = DeliveredAt.AddHours(-1.5);
            TimeSpan current = DeliveredAt.Subtract(DispatchedAt);
            double newSpeed = (Vehicle.Speed * previous.Hours) / current.Hours;

            Console.WriteLine($"The vehicle should increase its speed from {Vehicle.Speed} to {newSpeed}");

            Vehicle.Speed = newSpeed;

            Console.WriteLine($"Dispatching freight at {DispatchedAt}...");
            Vehicle.Deliver(Freight);
            Console.WriteLine($"The freight has been delivered at {DeliveredAt}!");
            Console.WriteLine("///////////////////////////");
        }
    }
}
