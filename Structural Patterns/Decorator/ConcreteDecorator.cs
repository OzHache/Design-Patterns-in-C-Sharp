//The ConcreteDecorator class has a field for storing a reference to a wrapped component object.
using UnityEngine;

namespace DecoratorPattern
{
    public class ConcreteDecoratorA : MonoBehaviour, IDecorator
    {
        private IComponent _component;
        public ConcreteDecoratorA(IComponent component)
        {
            _component = component;
        }
        public void Operation()
        {
            _component.Operation();
            Debug.Log("ConcreteDecoratorA.Operation()");
        }
        public void SecondaryOperation()
        {
            _component.SecondaryOperation();
            Debug.Log("ConcreteDecoratorA.SecondaryOperation()");
        }
    }
}