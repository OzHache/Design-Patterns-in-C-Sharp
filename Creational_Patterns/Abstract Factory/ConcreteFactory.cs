//The Concrete Factory class is responsible for creating the concrete products
using UnityEngine;

public class ConcreteFactory : MonoBehaviour, IAbstractFactory
{
    [SerializedField] private GameObject productA;
    [SerializedField] private MonoBehaviour[] productAComponents;
    [SerializedField] private GameObject productB;
    [SerializedField] private MonoBehaviour[] productBComponents;
    public IAbstractProductA CreateProductA()
    {
        return CreateProductA();
    }

    public IAbstractProductB CreateProductB()
    {
        return CreateProductB();
    }
    //Create Product A and Add the components
    private IAbstractProduct CreateProductA()
    {
        GameObject product = Instantiate(productA);
        foreach (MonoBehaviour component in productAComponents)
        {
            product.AddComponent(component.GetType());
        }
        return product.GetComponent<IAbstractProductA>();
    }
    //Create Product B and Add the components
    private IAbstractProduct CreateProductB()
    {
        GameObject product = Instantiate(productB);
        foreach (MonoBehaviour component in productBComponents)
        {
            product.AddComponent(component.GetType());
        }
        return product.GetComponent<IAbstractProductB>();
    }
}
    