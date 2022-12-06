//The Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.
using UnityEngine;

public class FactoryMethod : MonoBehaviour {
    //Factory Method for duplicating a GameObject
    public GameObject Duplicate(GameObject original) {
        return Instantiate(original);
    }
    //Factory Method for duplicating a MonoBehaviour
    public MonoBehaviour Duplicate(MonoBehaviour original) {
        return Instantiate(original);
    }
    //Factory Method for duplicating a ScriptableObject
    public ScriptableObject Duplicate(ScriptableObject original) {
        return Instantiate(original);
    }
    //Factory Method for duplicating a Component
    public Component Duplicate(Component original) {
        return Instantiate(original);
    }
    //Factory Method for duplicating a Texture
    public Texture Duplicate(Texture original) {
        return Instantiate(original);
    }
}