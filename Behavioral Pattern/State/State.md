# The State Pattern 
The State Pattern allows an object to alter its behavior when its internal state changes. The object will appear to change its class.
An example of when you might use this in game development:
When you have a character that can be in different states, such as walking, running, jumping, crouching, etc. You can use the State Pattern to handle the different states of the character. This is useful because you can have a single character class that can handle all of the different states of the character. This is better than having a separate class for each state, because it is easier to maintain and extend. You can also easily add new states to the character without having to change the existing code.

The Members of the State Pattern are:
- Context: The class that contains the state. This is the class that will change its behavior based on the state.
- State: The interface that defines the behavior of the state.
- ConcreteState: The class that implements the behavior of the state.
- Client: The class that uses the Context.
- Transition: The class that changes the state of the Context.
Transitions can be triggered by events, conditions, or guards. The Transition class can be extended to handle any of these:
- TransitionCondition: The class that determines when the Transition should occur.
- TransitionAction: The class that performs an action when the Transition occurs.
- TransitionGuard: The class that determines if the Transition should occur.
- TransitionEvent: The class that triggers the Transition.
- TransitionTarget: The class that determines the next state of the Context.
- TransitionTimeout: The class that determines when the Transition should occur.
- etc.


