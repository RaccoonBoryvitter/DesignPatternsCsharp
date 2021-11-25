using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Entity
{
    internal class Plane : Vehicle
    {
        public override void DispatchTo(string destination)
        {
            Console.WriteLine($"The order is dispatched on the plane to {destination}");
        }
    }
}
