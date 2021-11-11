using System;
using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    internal class CargoContainer : ICargo
    {
        private decimal weight;

        public List<ICargo> Children { get; set; } = new List<ICargo>();
        public override decimal Weight { get; set; }
        public override string Description { get; set; }

        public void Add(ICargo child)
        {
            Children.Add(child);
        }

        public void AddRange(IEnumerable<ICargo> children)
        {
            Children.AddRange(children);
        }

        public void Remove(ICargo child)
        {
            Children.Remove(child);
        }

        public override decimal GetWeight() => Children.Sum(children => children.Weight);

        public override string GetDescription()
        {
            var overall = Children.Select(i => i.Description)
                                  .Select(d => $" - {d};")
                                  .Aggregate((prev, next) => $"{prev}\n{next}");

            return $"List of all descriptions: \n{overall}";
        }
    }
}
