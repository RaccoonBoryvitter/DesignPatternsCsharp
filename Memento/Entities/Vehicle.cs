using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Entities
{
    [Serializable]
    internal class Vehicle
    {

        public Guid Id { get; set; }

        public string LicensePlate { get; set; }

        public double WeightCapacity { get; set; }

        public Driver Driver { get; set; }

        public Division Division { get; set; }

    }
}
