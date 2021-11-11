using Iterator.Models;

namespace Iterator.Utils
{
    internal class StraightIterator : Iterator
    {
        private CargoContainer _container;
        private int _pos = -1;
        private bool _reverse = false;

        public StraightIterator(CargoContainer container, bool reverse)
        {
            _container = container;
            _reverse = reverse;

            if(reverse)
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
            int nextPos = _pos + (_reverse ? -1 : 1);

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
            _pos = _reverse ? _container.All().Count - 1 : 0;
        }
    }
}
