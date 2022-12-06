# The Mediator
The Mediator Pattern is a behavioral design pattern that lets you reduce chaotic dependencies between objects. The pattern restricts direct communications between the objects and forces them to collaborate only via a mediator object.
An example for this might be a when the player takes damage, the player's health bar needs to be updated. The player's health bar is a separate object, so it can't directly update itself. Instead, it needs to send a message to the player object, which will then update the health bar.
The members of the Mediator Pattern are:
- Mediator: defines an interface for communicating with Colleague objects.
- ConcreteMediator: implements cooperative behavior by coordinating Colleague objects.
- Colleague: knows its Mediator object. Each Colleague class only knows its Mediator object. Colleagues don't know about each other.
- ConcreteColleague: each Colleague class only knows its Mediator object. Colleagues don't know about each other.
- Client: creates ConcreteColleague objects and configures their relationships.
