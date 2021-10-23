using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    internal class Route
    {
        public string From { get; set; }

        public string To { get; set; }

        public override string ToString()
        {
            return $" - Route: from {From} to {To}";
        }
    }
}
