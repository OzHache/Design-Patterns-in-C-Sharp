# The Template Pattern
The Template Pattern defines the skeleton of an algorithm in a method, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
An example of when you might use this in game development:
When you have a class that has a method that performs a series of steps. You can use the Template Pattern to define the steps of the method in a base class, and then have subclasses implement the steps. This is useful because you can have a single base class that can handle all of the different steps of the method. This is better than having a separate class for each step, because it is easier to maintain and extend. You can also easily add new steps to the method without having to change the existing code.
The members of the Template Pattern are:
- AbstractClass: The class that defines the skeleton of the algorithm.
- ConcreteClass: The class that implements the steps of the algorithm.
- Client: The class that uses the AbstractClass.
- Hook: The method that can be overridden by the ConcreteClass.