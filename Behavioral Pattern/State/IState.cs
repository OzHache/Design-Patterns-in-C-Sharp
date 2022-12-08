//The IState interface declares a method for executing a state-specific behavior.
namespace StatePattern {
    public interface IState {
        void Handle(Context context);
    }
}