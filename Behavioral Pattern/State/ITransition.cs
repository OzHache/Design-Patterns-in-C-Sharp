//ITransition interface declares a method for executing a transition-specific behavior.
namespace StatePattern {
    public interface ITransition {
        void Handle(Context context);
    }
}
    //Examples of transitions:
    //Transition from ConcreteStateA to ConcreteStateB
    public class TransitionAtoB : ITransition {
        public void Handle(Context context) {
            context.State = new ConcreteStateB();
        }

    //Transition from ConcreteStateB to ConcreteStateA
    public class TransitionBtoA : ITransition {
        public void Handle(Context context) {
            context.State = new ConcreteStateA();
        }
    }
    //Customizeable transitions:
    public class CustomTransition : ITransition {
        private IState _state;
        public CustomTransition(IState state) {
            this._state = state;
        }
        public void Handle(Context context) {
            context.State = this._state;
        }
    }
}