//The Aggregate is the one that will be used to create the iterator.
namespace Iterator_Pattern
{
    public interface IAggregate
    {
        IIterator CreateIterator();
    }
}