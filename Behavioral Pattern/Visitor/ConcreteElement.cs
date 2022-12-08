//Concrete Element class 
//Each Concrete Element must implement the Accept operation that takes a visitor as an argument.
namespace VisitorPattern {
    public class ConcreteElementA : IElement {
        public void Accept(IVisitor visitor) {
            visitor.VisitConcreteElementA(this);
        }
        public void OperationA() {
            Debug.Log("ConcreteElementA.OperationA() called.");
        }
    }
    public class ConcreteElementB : IElement {
        public void Accept(IVisitor visitor) {
            visitor.VisitConcreteElementB(this);
        }
        public void OperationB() {
            Debug.Log("ConcreteElementB.OperationB() called.");
        }
    }
}