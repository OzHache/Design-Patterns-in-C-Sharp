# The Iterator
The Iterator Pattern is a behavioral design pattern that lets you traverse elements of a collection without exposing its underlying representation (list, stack, tree, etc.).
The members of the Iterator Pattern are:
- Iterator: declares an interface for accessing and traversing elements.
- ConcreteIterator: implements the Iterator interface. Keeps track of the current position in the traversal of the aggregate.
- Aggregate: declares an interface for creating an Iterator object.
- ConcreteAggregate: implements the Iterator creation interface to return an instance of the proper ConcreteIterator.
- Client: accesses the elements of an aggregate object sequentially without knowing its underlying representation.
