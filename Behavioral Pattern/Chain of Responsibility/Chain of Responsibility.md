# Chain of Responsibility
The Chain of Responsibility is a behavioral design pattern that lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.
The members of the Chain of Responsibility are:
- Handler: defines an interface for handling requests.
- ConcreteHandler: handles requests it is responsible for. Can access its successor. If the ConcreteHandler can handle the request, it does so; otherwise it forwards the request to its successor.
- Client: initiates the request to a ConcreteHandler object on the chain.
