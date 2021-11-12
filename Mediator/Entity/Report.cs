using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Entity
{
    class Report
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Client From { get; set; }

        public Client To { get; set; }

        public Freight Freight { get; set; }

        public Vehicle Vehicle { get; set; }

        public override string ToString()
        {
            return $" + Report ID: {Id};\n" +
                   $" + From:\n{From}\n" +
                   $" + To:\n{To}\n" +
                   $" + Freight:\n{Freight}\n" +
                   $" + Vehicle:\n{Vehicle}\n";
        }

    }
}
