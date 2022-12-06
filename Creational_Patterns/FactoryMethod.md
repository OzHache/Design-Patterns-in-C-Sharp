# The Factory Method
The Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.
The Members of the Factory Method are:
- Factory Method: defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
- Creator class: declares the factory method, which returns an object of type Product. Creator may also define a default implementation of the factory method that returns a default ConcreteProduct object. May call the factory method to create a Product object.
- ConcreteCreator class: overrides the factory method to return an instance of a ConcreteProduct.
- Product class: defines the interface of objects the factory method creates.
