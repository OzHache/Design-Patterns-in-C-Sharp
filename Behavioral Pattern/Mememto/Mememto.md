# The Mememto Pattern
The Mememto Pattern is a behavioral design pattern that lets you save and restore the previous state of an object without revealing the details of its implementation.  
The members of the Mememto Pattern are:
- Originator: creates a memento containing a snapshot of its current internal state. Uses the memento to restore its internal state.
- Memento: stores internal state of the Originator object. The memento may store as much or as little of the originator's internal state as necessary at its originator's discretion.
- Caretaker: is responsible for the memento's safekeeping. Never operates on or examines the contents of a memento.
- Client: creates a caretaker object and, subsequently, the originator object. The client configures the originator and the caretaker.