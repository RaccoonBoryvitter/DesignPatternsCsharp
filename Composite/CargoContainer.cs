using System;
using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    internal class CargoContainer : ICargo
    {
        public List<ICargo> Children { get; set; } = new List<ICargo>();
        public override decimal Weight { get => GetWeight(); set => throw new NotImplementedException(); }
        public override string Description { get => GetDescription(); set => throw new NotImplementedException(); }

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

        protected override decimal GetWeight() => Children.Sum(children => children.Weight);

        protected override string GetDescription()
        {
            var overall = Children.Select(i => i.Description)
                                  .Select(d => $" - {d};")
                                  .Aggregate((prev, next) => $"{prev}\n{next}");

            return $"List of all descriptions: \n{overall}";
        }
    }
}
