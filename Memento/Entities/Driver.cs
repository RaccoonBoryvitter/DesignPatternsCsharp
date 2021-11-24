using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Entities
{
    [Serializable]
    internal class Driver
    {

        public Guid Id { get; set; }

        public string Name { get; set; }

        public byte Age { get; set; }

        public DriverCategory Category { get; set; }

        public Division Division { get; set; }

    }
}
