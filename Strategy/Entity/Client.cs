using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Entity
{
    internal class Client
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public string City { get; set; }
    }
}
