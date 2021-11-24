using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Entities
{
    internal class Order
    {
        public Guid Id { get; set; }

        public Client Client { get; set; }

        public Freight Freight { get; set; }
    }
}
