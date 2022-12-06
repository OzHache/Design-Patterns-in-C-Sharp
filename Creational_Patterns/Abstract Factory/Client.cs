//The Client class is responsible for interacting with the factory and the products through the abstract interfaces
using UnityEngine;

public class Client : MonoBehaviour {
    private IAbstractFactory factory;
    private IAbstractProductA productA;
    private IAbstractProductB productB;

    private void Start() {
        factory = new ConcreteFactory();
        productA = factory.CreateProductA();
        productB = factory.CreateProductB();
        productA.Activate();
        productB.Activate();
    }
}