//The Subject interface declares a set of methods for managing subscribers.
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}