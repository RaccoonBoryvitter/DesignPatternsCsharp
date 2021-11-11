using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    internal class Freight : ICargo
    {

        public override decimal Weight { get => GetWeight(); set { _weight = value; }  }
        public override string Description { get => GetDescription(); set { _description = value; } }

        public override decimal GetWeight() => _weight;

        public override string GetDescription() => _description;

    }
}
