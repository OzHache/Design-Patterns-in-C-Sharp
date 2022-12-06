//The Abstract factory is the opposite of the prototype pattern. It is used to create a family of related objects without specifying their concrete classes.
//The members of the Absract Factory are:
//AbstractFactory: Declares an interface for operations that create abstract products.
//ConcreteFactory: Implements the operations to create concrete product objects.
//AbstractProduct: Declares an interface for a type of product object.
//Product: Defines a product object to be created by the corresponding concrete factory. Implements the AbstractProduct interface.
//Client: Uses only interfaces declared by AbstractFactory and AbstractProduct classes.
using UnityEngine;

interface IAbstractFactory
{
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}