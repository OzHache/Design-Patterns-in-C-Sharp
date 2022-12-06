Abstract Factory Pattern
The Abstract Factory Pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.
The Abstract Factory Pattern is a creational pattern that provides an interface for creating families of related or dependent objects without specifying their concrete classes. The Abstract Factory Pattern is often implemented with Factory Methods, but it can also be implemented using Prototype.
The Abstract Factory Pattern is used to:
* Provide a client with a set of related or dependent objects. The "family" of objects created by the factory are determined at run-time.
* Refer to the newly created object through a common interface.
* The new operator considered harmful.
* The Abstract Factory Pattern is often implemented with Factory Methods, but it can also be implemented using Prototype.

The Members of the Abstract Factory Pattern are:
* AbstractFactory - declares an interface for operations that create abstract products.
* ConcreteFactory - implements the operations to create concrete product objects.
* AbstractProduct - declares an interface for a type of product object.
* Product - defines a product object to be created by the corresponding concrete factory. Implements the AbstractProduct interface.
* Client - uses interfaces declared by AbstractFactory and AbstractProduct classes.
