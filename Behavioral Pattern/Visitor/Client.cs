//The Client
//The Client is only responsible for executing the state transition methods.
using UnityEngine;
namespace StatePattern {
    public class Client : MonoBehaviour {
        private IObjectStructure _objectStructure;

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
            // Create new object structure
            this._objectStructure = new ObjectStructure();
            // Add new elements
            this._objectStructure.Add(new ElementA());
            this._objectStructure.Add(new ElementB());
            // Execute visitor
            this._objectStructure.Accept(new ConcreteVisitorA());
            // Execute visitor
            this._objectStructure.Accept(new ConcreteVisitorB());
            
        }
    }
}