using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Entity
{
    internal class Driver
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $" - Name: {Name};\n";
        }
    }
}
