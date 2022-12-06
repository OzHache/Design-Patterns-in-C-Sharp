# The Flyweight Pattern
The Flyweight Pattern is also known as the Cache Pattern
The Members of the Flyweight Pattern are:
- The Flyweight which defines the interface that the client expects to see
- The Concrete Flyweight which implements the Flyweight interface
- The Flyweight Factory which is the class that creates and manages the Flyweight objects
- The Unshared Concrete Flyweight which is the class that implements the Flyweight interface
  - Note that the Unshared Concrete Flyweight is not shared with other objects
- The Client which is the class that uses the Flyweight interface

The Flyweight pattern is differentiated from the Singleton pattern in that the Singleton pattern is used to ensure that only one instance of a class is created, while the Flyweight pattern is used to ensure that only one instance of a class is created for each unique state of that class.
