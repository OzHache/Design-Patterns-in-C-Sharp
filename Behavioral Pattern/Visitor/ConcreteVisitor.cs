//Concrete Visitor class 
//The Concrete Visitor implements each operation declared by Visitor. Each operation implements a fragment of the algorithm defined for the corresponding class of object in the structure. ConcreteVisitor provides the context for the algorithm and stores its local state. This state often accumulates results during the traversal of the structure.
namespace VisitorPattern {
    public class ConcreteVisitor : IVisitor {
        public void VisitConcreteElementA(ConcreteElementA concreteElementA) {
            Debug.Log(concreteElementA.GetType().Name + " visited by " + this.GetType().Name);
        }
        public void VisitConcreteElementB(ConcreteElementB concreteElementB) {
            Debug.Log(concreteElementB.GetType().Name + " visited by " + this.GetType().Name);
        }
    }
}