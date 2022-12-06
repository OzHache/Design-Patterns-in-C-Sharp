//The Concrete Affregate is the one that will be used to create the iterator.
namespace Iterator_Pattern
{
    public class ConcreteAggregate : IAggregate
    {
        private List<object> _items = new List<object>();
        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
        public int Count
        {
            get { return _items.Count; }
        }
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
}