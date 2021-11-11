using System.Collections;
using System.Collections.Generic;
using Iterator.Utils;

namespace Iterator.Models
{
    internal class CargoContainer : IteratorAggregate
    {
        private readonly List<Freight> _collection = new List<Freight>();
        private bool _direction = false;

        public void ToggleDirection()
        {
            _direction = !_direction;
        }

        public List<Freight> All()
        {
            return _collection;
        }

        public Freight this[int i]
        {
            get => _collection[i];
            set => _collection[i] = value;
        }

        public void Add(Freight item)
        {
            _collection.Add(item);
        }

        public void AddRange(IEnumerable<Freight> items)
        {
            _collection.AddRange(items);
        }

        public override IEnumerator GetEnumerator()
        {
            //return new StraightIterator(this, _direction);
            return new WeightDependendIterator(this, _direction);
        }
    }
}
