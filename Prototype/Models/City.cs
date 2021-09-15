using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Prototype.Models
{
    internal class City
    {
        internal string AreaISO { get; set; }
        internal string Name { get; set; }
        internal string PostalCode { get; set; }

        public City(string areaISO, string name, string postalCode)
        {
            AreaISO = areaISO;
            Name = name;
            PostalCode = postalCode;
        }

        public City Clone()
        {
            return this.MemberwiseClone() as City;
        }

        public override bool Equals(object obj)
        {
            return obj is City city &&
                   AreaISO == city.AreaISO &&
                   Name == city.Name &&
                   PostalCode == city.PostalCode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(AreaISO, Name, PostalCode);
        }
    }
}
