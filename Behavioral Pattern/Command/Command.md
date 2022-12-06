# The Command Pattern   
The Command Pattern is a behavioral design pattern that turns a request into a stand-alone object that contains all information about the request. This transformation lets you parameterize methods with different requests, delay or queue a request's execution, and support undoable operations.
The members of the Command Pattern are:
- Command: declares an interface for executing an operation.
- ConcreteCommand: defines a binding between a Receiver object and an action. Implements Execute by invoking the corresponding operation(s) on Receiver.
- Client: creates a ConcreteCommand object and sets its receiver.
- Invoker: asks the command to carry out the request.
- Receiver: knows how to perform the operations associated with carrying out a request. Any class may serve as a Receiver.

The difference between a client and the invoker is that the client is the one that creates the command object and sets its receiver, while the invoker is the one that asks the command to carry out the request.