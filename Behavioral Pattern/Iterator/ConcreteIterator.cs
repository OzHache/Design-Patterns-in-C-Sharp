//The Concrete Iterator is the one that will be used to iterate through the collection.
namespace Iterator_Pattern
{
    public class ConcreteIterator : IIterator
    {
        private ConcreteAggregate _aggregate;
        private int _current = 0;
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this._aggregate = aggregate;
        }
        public object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count)
            {
                ret = _aggregate[_current];
                _current++;
            }
            return ret;
        }
        public bool HasNext()
        {
            return _current < _aggregate.Count;
        }
    }
}