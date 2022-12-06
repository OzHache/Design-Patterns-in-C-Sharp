//The Client in a Flywheel Pattern is the client code that works with the flyweight interface. It can be a simple or complex flyweight. The client code is coupled to the Flyweight interface. The client code can work with both simple and complex flyweights via the Flyweight interface.
namespace FlywheelPattern
{
    using UnityEngine;
    
    public class Client : MonoBehaviour {
        void Start() {
            //Create a flyweight factory
            FlyweightFactory factory = new FlyweightFactory();
            //Create a flyweight
            IFlyweight flyweight = factory.GetFlyweight("A");
            //Call the primary method
            flyweight.Operation();
            //Call the secondary method
            flyweight.SecondaryOperation();
        }
    }
}