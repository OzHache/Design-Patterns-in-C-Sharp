# The Decorator
The Decorator is a structural design pattern that lets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the behaviors.
The Decorator pattern is also known as the Wrapper pattern.
The Members of the Decorator Pattern are:
- The Component which is the interface that the client expects to see
- The Concrete Component which is the class that implements the Component interface
- The Decorator which is the class that implements the Component interface
- The Concrete Decorator which is the class that implements the Decorator interface
- The Client which is the class that uses the Component interface

The Decorator pattern is differentiated from the Adapter pattern in that the Adapter pattern is used to adapt an interface to another interface, while the Decorator pattern is used to add functionality to an object. The Decorator pattern is also differentiated from the Composite pattern in that the Composite pattern is used to compose objects into tree structures and then work with these structures as if they were individual objects, while the Decorator pattern is used to add functionality to an object.