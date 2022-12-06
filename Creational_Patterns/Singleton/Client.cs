//The Client in the Singleton pattern is the class that uses the Singleton class.
namespace Singleton_Pattern
{
    using UnityEngine;
    
    public class Client : MonoBehaviour {
        private void Start() {
            //Call the PrintMessage method on the SingletonExample class
            SingletonExample.Instance.PrintMessage();
        }
    }
}