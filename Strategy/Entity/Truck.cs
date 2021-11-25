using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Entity
{
    internal class Truck : Vehicle
    {
        public override void DispatchTo(string destination)
        {
            Console.WriteLine($"The order is dispatched on the truck to {destination}");
        }
    }
}
