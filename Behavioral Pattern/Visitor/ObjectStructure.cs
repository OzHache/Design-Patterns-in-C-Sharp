//The Object Structure can enumerate its elements.
namespace VisitorPattern
{
    public interface IObjectStructure
    {
        void Accept(IVisitor visitor);
    }

    //the concrete Object Structure class
    public class ObjectStructure : IObjectStructure
    {
        private List<IElement> elements = new List<IElement>();
        public void Attach(IElement element)
        {
            elements.Add(element);
        }
        public void Detach(IElement element)
        {
            elements.Remove(element);
        }
        public void Accept(IVisitor visitor)
        {
            foreach (IElement element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}