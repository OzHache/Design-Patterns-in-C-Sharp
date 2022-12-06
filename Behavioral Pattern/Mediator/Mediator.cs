// The Mediator is the one that will be used to communicate between the objects.
namespace Mediator_Pattern
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}