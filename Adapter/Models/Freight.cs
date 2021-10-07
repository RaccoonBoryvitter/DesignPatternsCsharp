using System;
using System.Collections.Generic;
using Adapter.Services;

namespace Adapter.Models
{
    internal class Freight
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string To { get; set; }

        /// <summary>
        /// Represents a weight in kilograms.
        /// </summary>
        public double Weight { get; set; }

        public string Description { get; set; }

        public virtual string GetInfo()
        {
            string info = $"\n + Identification number: {Id}"
                        + $"\n + From: Custody"
                        + $"\n + To: {To}"
                        + $"\n + Weight: {Weight} kg"
                        + $"\n + Description: \n\t{Description}";

            return info;
        }
    }
}
