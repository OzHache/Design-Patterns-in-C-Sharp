//The Adapter pattern is used to convert the interface of a class into another interface the clients expect.
//Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
//The Adapter pattern is also known as the Wrapper pattern.
using UnityEngine;
namespace AdapterPattern{
    public class Adapter : MonoBehaviour {
        //The Adapter makes the Adaptee's interface compatible with the Target's interface.
        private Adaptee adaptee = new Adaptee();
        //The Adapter makes the Adaptee's interface compatible with the Target's interface.
        public void Request() {
            //The Adapter translates the interface of Adaptee into a Target interface.
            adaptee.SpecificRequest();
        }
    }
}