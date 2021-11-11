using System;

namespace Iterator.Models
{
    internal class Freight
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public double Weight { get; set; }

        public MaterialType Material { get; set; }

        public SecurityType Security { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return "Freight info:\n"
                 + $" - ID: {Id}\n"
                 + $" - Weight: {Weight}\n"
                 + $" - Material: {Enum.GetName(Material.GetType(), Material)}\n"
                 + $" - Security: {Enum.GetName(Security.GetType(), Security)}\n"
                 + $" - Description: {Description}\n";
        }
    }
}
