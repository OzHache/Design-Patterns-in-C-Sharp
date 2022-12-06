//Singleton example of a MonoBehavior
//Singletons are useful for things like Managers, which are used to control the flow of the game
using UnityEngine;
namespace Singleton_Pattern{
    public class SingletonExample : MonoBehaviour {
        //Create a static instance of the class
        private static SingletonExample instance;
        //Create a public property to access the instance
        public static SingletonExample Instance{
            get{
                //If the instance is null, create a new instance
                if(instance == null){
                    instance = new GameObject("SingletonExample").AddComponent<SingletonExample>();
                }
                //Return the instance
                return instance;
            }
        }
        //Create a private constructor so that the class cannot be instantiated
        private SingletonExample(){}
        //Create a public method to destroy the instance
        public static void Destroy(){
            Destroy(instance.gameObject);
            instance = null;
        }
        //Create a public method to print a message
        public void PrintMessage(){
            Debug.Log("Hello World!");
        }
    }
}