using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Models
{
    internal class Freight
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string From { get; set; }

        public string To { get; set; }

        public double Weight { get; set; }

        public string Description { get; set; }

        public Freight(string from, string to, double weight, string description)
        {
            From = from;
            To = to;
            Weight = weight;
            Description = description;
        }
    }
}
