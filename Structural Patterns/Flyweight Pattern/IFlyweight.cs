//The IFlyweight interface declares a method for receiving extrinsic state, common to all concrete flyweights.
namespace FlyweightPattern
{
    public interface IFlyweight
    {
        void Operation();
        void SecondaryOperation();
    }
}