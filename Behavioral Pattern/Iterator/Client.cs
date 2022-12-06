//The Client is the one that will be used to create the iterator and iterate through the collection.
namespace Iterator_Pattern
{
    public class Client
    {
        public void Main()
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";
            IIterator i = a.CreateIterator();
            object item = i.Next();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
        }
    }
}
