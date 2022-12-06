// The Adaptee contains some useful behavior, but its interface is incompatible with the existing client code. The Adaptee needs some adaptation before the client code can use it.
using UnityEngine;
namespace AdapterPattern{
    public class Adaptee : MonoBehaviour {
        //The Adaptee contains some useful behavior, but its interface is incompatible with the existing client code. The Adaptee needs some adaptation before the client code can use it.
        public void SpecificRequest() {
            Debug.Log("Called SpecificRequest()");
        }
    }
}