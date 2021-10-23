using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    internal class RouteFlyweight
    {
        private Route _shared;

        public RouteFlyweight(Route shared)
        {
            _shared = shared;
        }

        public void ShowSharedAndUniqueStates(Shipment shipment)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Shared state: {_shared}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Unique state: {shipment}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
