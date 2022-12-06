//The Client in the Composite pattern is the client code that works with the composite structure. It can be a simple or complex component. The client code is coupled to the Component interface. The client code can work with both simple and complex components via the Component interface.
using UnityEngine;
namespace CompositePattern{
    public class Client : MonoBehaviour {
        void Start() {
            //Create a tree structure
            Composite root = new Composite();
            root.Add(new Leaf());
            root.Add(new Leaf());
            //Create a branch
            Composite branch = new Composite();
            branch.Add(new Leaf());
            branch.Add(new Leaf());
            //Add branch to root
            root.Add(branch);
            //Add and remove a leaf
            Leaf leaf = new Leaf();
            root.Add(leaf);
            root.Remove(leaf);
            //Recursively call the primary method
            root.Operation();
            //Recursively call the secondary method
            root.SecondaryOperation();
        }
    }
}