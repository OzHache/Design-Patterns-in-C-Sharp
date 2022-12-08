// The Client in a Template pattern is responsible for executing the template method. The template method is a method that defines the skeleton of an algorithm. The template method calls primitive operations, which are implemented by concrete subclasses. The template method is final, so it cannot be overridden by concrete subclasses.
namespace TemplatePattern {
    public class Client : MonoBehaviour {
        void Start() {
            // Create new context
            AbstractClass context = new ConcreteClass();
            // Execute template method
            context.TemplateMethod();
        }
    }
}