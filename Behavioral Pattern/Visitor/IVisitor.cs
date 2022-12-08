//The IVisitor interface declares a set of visiting methods that correspond to component classes. The signature of a visiting method allows the visitor to identify the exact class of the component that it's dealing with.
namespace VisitorPattern {
    public interface IVisitor {
        void VisitConcreteElementA(ConcreteElementA element);
        void VisitConcreteElementB(ConcreteElementB element);
    }
}