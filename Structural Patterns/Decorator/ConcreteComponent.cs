//The ConcreteComponent class defines an object to which additional responsibilities can be attached.
namespace DecoratorPattern
{
    using UnityEngine;

    public class ConcreteComponent : MonoBehaviour, IComponent
    {
        public void Operation()
        {
            Debug.Log("ConcreteComponent.Operation()");
        }
        public void SecondaryOperation()
        {
            Debug.Log("ConcreteComponent.SecondaryOperation()");
        }
    }
}