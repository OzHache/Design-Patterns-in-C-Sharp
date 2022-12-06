//The Leaf class represents the end objects of a composition. A leaf can't have any children.
//It defines behavior for primitive objects in the composition.
namespace CompositePattern
{
    public class Leaf : IComponent
    {
        public void Operation()
        {
            Debug.Log("Leaf Operation");
        }
        public void SecondaryOperation()
        {
            Debug.Log("Leaf Secondary Operation");
        }
    }
}