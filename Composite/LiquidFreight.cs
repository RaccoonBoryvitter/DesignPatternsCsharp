using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    internal class LiquidFreight : Freight
    {
        public decimal Density { get; set; }
        public decimal Volume { get; set; }

        public override decimal Weight 
        { 
            get => GetWeight(); 
            set 
            {
                _weight = value;
                Volume = value / Density;
            } 
        }

        protected override decimal GetWeight() => Density * Volume;
    }
}
