//The Client is only responsible for executing the state transition methods.
using UnityEngine;
namespace StatePattern {
    public class Client : MonoBehaviour {
        void Start() {
            // Create new context
            Context context = new Context();
            // Initialize with ConcreteStateA
            context.State = new ConcreteStateA();
            // Execute state transition
            context.Request();
            // Execute state transition
            context.Request();
            // Execute state transition
            context.Request();
        }
    }
}