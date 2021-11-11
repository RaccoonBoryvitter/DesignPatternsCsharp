using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    internal abstract class ICargo
    {
        protected readonly Guid _id = Guid.NewGuid();
        protected decimal _weight;
        protected string _description;

        public abstract decimal Weight { get; set; }
        public abstract string Description { get; set; }

        abstract public decimal GetWeight();
        abstract public string GetDescription();
    }
}
