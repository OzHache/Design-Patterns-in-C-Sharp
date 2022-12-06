//The Subsystem can accept requests either from the facade or client directly.
//In any case, to the Subsystem, the Facade is yet another client, and it's not a part of the Subsystem.
//The Subsystem is a part of the system, but it's not a part of the Facade.
namespace FacadePattern{
    public class SubSystem1
    {
        public string Operation1()
        {
            return "Subsystem1: Ready!\n";
        }
        public string OperationN()
        {
            return "Subsystem1: Go!\n";
        }
    }
    public class SubSystem2
    {
        public string Operation1()
        {
            return "Subsystem2: Get ready!\n";
        }
        public string OperationZ()
        {
            return "Subsystem2: Fire!\n";
        }
    }
}
