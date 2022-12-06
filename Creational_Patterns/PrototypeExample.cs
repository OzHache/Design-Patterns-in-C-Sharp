//The prototype Pattern is used to instantiate a new object by copying all of the properties of an existing object, creating an independent clone. This practise is particularly useful when the construction of a new object is inefficient.
using UnityEngine;
using UnityEngine;

public class PrototypeExample : MonoBehaviour {
    //Create a new instance of the class
    private PrototypeExample instance;
    #region Singleton
    //Create a public property to access the instance
    public PrototypeExample Instance {
        get {
            //If the instance is null, create a new instance
            if (instance == null) {
                instance = new PrototypeExample();
            }
            //Return the instance
            return instance;
        }
    }
    //Create a private constructor to prevent the class from being instantiated
    private PrototypeExample() {
        //in Unity we can check to see if there is an instance of the class already
        instance = GameObject.FindObjectOfType<PrototypeExample>();
        //If there is no instance, create a new game object and attach the class to it
        if (instance == null) {
            GameObject go = new GameObject("PrototypeExample");
            instance = go.AddComponent<PrototypeExample>();
        }
        return instance;
    }
    #endregion
    //Create a public method to clone the object
    public PrototypeExample Clone() {
        //Return a copy of the object
        return (PrototypeExample) this.MemberwiseClone();
    }
}