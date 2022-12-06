//The Client works with (is coupled to) the Target interface.
using UnityEngine;
namespace AdapterPattern{
    public class Client : MonoBehaviour {
        void Start() {
            //Create adapter and place a request
            ITarget target = new Adapter();
            //Request are used to call the specific method
            target.Request();
        }
        
    }
}