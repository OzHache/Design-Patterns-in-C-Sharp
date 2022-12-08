//The Abstract Class defines a template method that contains a skeleton of some algorithm, composed of calls to (usually) abstract primitive operations.
//Concrete subclasses should implement these operations, but leave the template method itself intact.
//The Abstract Class allows clients to invoke the template method to execute the algorithm. Clients do not have to know the concrete class of an object they work with, as long as it supports the template method.
namespace TemplatePattern {
    public abstract class AbstractClass {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();
        // The template method defines the skeleton of an algorithm.
        public void TemplateMethod() {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Debug.Log("AbstractClass says: I am doing the bulk of the work");
        }
        //hook
        public virtual void Hook() { }
        
    }
}