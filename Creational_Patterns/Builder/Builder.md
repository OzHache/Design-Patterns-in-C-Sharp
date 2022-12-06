The Builder Pattern is used to separate the construction of a complex object from its representation so that the same construction process can create different representations.
The members of the Builder Pattern are:
*Product - The object being built
*Builder - Abstract class that defines the interface for creating parts of the Product object
*ConcreteBuilder - Concrete class that implements the Builder interface and constructs and assembles parts of the product by implementing the Builder's methods
*Director - Constructs an object using the Builder interface
*Client - Creates a Director object and configures it with a specific Builder object
