//The RefinedAbstraction extends the interface defined by Abstraction.
using UnityEngine;
using UnityEngine;
namespace BridgePattern{
    public class RefinedAbstraction : Abstraction
    {
        //The RefinedAbstraction extends the interface defined by Abstraction.
        public override void Operation()
        {
            implementor.Operation();
            Debug.Log("Called RefinedAbstraction.Operation()");
        }
    }
}