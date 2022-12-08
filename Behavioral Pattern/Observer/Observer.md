# Observer Pattern
The Observer Pattern defines a one-to-many dependency between objects so that when one object changes state, all of its dependents are notified and updated automatically.
The members of the Observer Pattern are:
- Subject: maintains a list of observers, facilitates adding or removing observers
- Observer: provides an update interface for objects that need to be notified of a Subject's changes of state
- ConcreteSubject: broadcasts notifications to observers on changes of state, stores the state of ConcreteObservers
- ConcreteObserver: stores a reference to the ConcreteSubject, implements an update interface for the Observer to ensure state is consistent with the Subject's
