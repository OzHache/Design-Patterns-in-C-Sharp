//The Composite class represents the complex components that may have children.
//It stores child components and implements child-related operations in the Component interface.
using UnityEngine;
namespace CompositePattern
{
    public class Composite : IComponent
    {
        private List<IComponent> _children = new List<IComponent>();
        public void Add(IComponent component)
        {
            _children.Add(component);
        }
        public void Remove(IComponent component)
        {
            _children.Remove(component);
        }
        public void Operation()
        {
            foreach (IComponent component in _children)
            {
                component.Operation();
            }
        }
        public void SecondaryOperation()
        {
            foreach (IComponent component in _children)
            {
                component.SecondaryOperation();
            }
        }
    }
}