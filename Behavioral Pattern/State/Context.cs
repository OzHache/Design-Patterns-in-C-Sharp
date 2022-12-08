//The Context defines the interface of interest to clients. It also maintains a reference to an instance of a State subclass, which represents the current state of the Context.
namespace StatePattern {
    public class Context {
        private IState _state;
        public IState State {
            get { return _state; }
            set {
                _state = value;
                Debug.Log("State: " + _state.GetType().Name);
            }
        }
        public Context() {
            this.State = null;
        }
        public void Request() {
            this.State.Handle(this);
        }
    }
}