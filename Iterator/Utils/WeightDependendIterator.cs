using System.Linq;
using Iterator.Models;

namespace Iterator.Utils
{
    internal class WeightDependendIterator : Iterator
    {
        private CargoContainer _container;
        private int _pos = -1;
        private bool _desc = false;

        public WeightDependendIterator(CargoContainer container, bool desc)
        {
            _container = new CargoContainer();
            _container.AddRange(
                container.All()
                         .OrderBy(item => item.Weight)
                         .ToArray()
            );
            _desc = desc;

            if (desc)
            {
                _pos = _container.All().Count;
            }
        }

        public override object Current()
        {
            return _container[_pos];
        }

        public override int Key()
        {
            return _pos;
        }

        private bool IsInRange(int index)
        {
            return index >= 0 && index < _container.All().Count;
        }

        public override bool MoveNext()
        {
            int nextPos = _pos + (_desc ? -1 : 1);

            if (IsInRange(nextPos))
            {
                _pos = nextPos;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            _pos = _desc ? _container.All().Count - 1 : 0;
        }
    }
}
