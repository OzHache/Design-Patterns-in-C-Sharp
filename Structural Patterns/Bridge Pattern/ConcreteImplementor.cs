//The ConcreteImplementor provides the implementation of the Implementor interface and defines its concrete implementation.
using UnityEngine;
namespace BridgePattern{
    public class ConcreteImplementor : MonoBehaviour, IImplementor
    {

        public void Operation()
        {
            Debug.Log("Called ConcreteImplementor.Operation()");
        }
    }
}