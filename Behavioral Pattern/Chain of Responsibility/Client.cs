//The Client class is responsible for creating the chain of handlers and passing the request to the first handler.
namespace ChainOfResponsibility
{
    public class Client : MonoBehaviour
    {
        void Start()
        {
            IHandler handler1 = new ConcreteHandler1();
            IHandler handler2 = new ConcreteHandler2();
            handler1.SetNext(handler2);
            Request request = new Request("Request 1", "This is a request", 2);
            handler1.Handle(request);
        }
    }
}