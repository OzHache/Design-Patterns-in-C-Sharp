//The Builder is an interface for creating a complex object. It allows you to separate the construction of a complex object from its representation so that the same construction process can create different representations.
public interface IBuilder
{
    void BuildPartA();
    void BuildPartB();
    void BuildPartC();
}