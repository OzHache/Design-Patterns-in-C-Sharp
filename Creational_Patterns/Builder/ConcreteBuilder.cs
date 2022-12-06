//The Concrete Builder class is responsible for creating the concrete products
using UnityEngine;

public class ConcreteBuilder : MonoBehaviour, IBuilder {
    [SerializedField] private GameObject productA;
    [SerializedField] private MonoBehaviour[] productAComponents;
    [SerializedField] private GameObject productB;
    [SerializedField] private MonoBehaviour[] productBComponents;
    public IProduct CreateProductA() {
        return CreateProduct();
    }

    public IProduct CreateProductB() {
        return CreateProductB();
    }
    //Create Product A and Add the components
    private IProduct CreateProductA() {
        GameObject product = Instantiate(productA);
        foreach (MonoBehaviour component in productAComponents) {
            product.AddComponent(component.GetType());
        }
        return product.GetComponent<IProduct>();
    }
    //Create Product B and Add the components
    private IProduct CreateProductB() {
        GameObject product = Instantiate(productB);
        foreach (MonoBehaviour component in productBComponents) {
            product.AddComponent(component.GetType());
        }
        return product.GetComponent<IProduct>();
    }
}