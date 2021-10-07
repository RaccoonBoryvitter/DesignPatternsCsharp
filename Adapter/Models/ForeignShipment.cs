using System;
using System.Collections.Generic;
using Adapter.Services;

namespace Adapter.Models
{
    internal class ForeignShipment
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string From { get; set; }

        /// <summary>
        /// Represents weight in pounds.
        /// </summary>
        public double Weight { get; set; }

        public string Description { get; set; }

        private readonly List<string> cities = new List<string>
        {
            "Chicago", "New-York", "Los-Angeles", "Texas"
        };

        public ForeignShipment(double weight, string description)
        {
            From = ListRandomPicker.PickFromList(cities);
            Weight = weight;
            Description = description;
        }

        public string GetInfo()
        {
            string info = $"\n + Identification number: {Id}"
                        + $"\n + From: {From}"
                        + $"\n + To: Custody"
                        + $"\n + Weight: {Weight} lbs"
                        + $"\n + Description: \n\t{Description}";

            return info;
        }
    }
}
