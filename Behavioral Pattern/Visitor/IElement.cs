//IElement interface declares an Accept operation that takes a visitor as an argument.
public interface IElement
{
    void Accept(IVisitor visitor);
}