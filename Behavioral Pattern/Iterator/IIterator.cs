//The Iterator is the one that will be used to iterate through the collection.
namespace Iterator_Pattern
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}