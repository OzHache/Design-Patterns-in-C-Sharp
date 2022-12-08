//The Concrete Class must implement all abstract operations of the base class. It may also override some operations with a default implementation.
namespace TemplatePattern {
    public class ConcreteClass : AbstractClass {
        public override void PrimitiveOperation1() {
            Debug.Log("ConcreteClass says: Implemented PrimitiveOperation1");
        }
        public override void PrimitiveOperation2() {
            Debug.Log("ConcreteClass says: Implemented PrimitiveOperation2");
        }
        //Optionally override the hook
        public override void Hook() {
            Debug.Log("ConcreteClass says: Overridden Hook");
        }
    }
}
