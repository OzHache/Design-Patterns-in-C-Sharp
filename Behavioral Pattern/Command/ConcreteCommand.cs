//Concrete Command is the command that will be executed.
using UnityEngine;
namespace CommandPattern
{
    public class ConcreteCommand : MonoBehaviour, ICommand
    {
        //The reciever is the one that will be executing the command.
        private Reciever _reciever;
        //The command will be expecting a reciever to be passed in.
        public ConcreteCommand(Reciever reciever)
        {
            _reciever = reciever;
        }
        //The command will be expecting a direction to be passed in.
        public void Execute(Vector3 direction)
        {
            _reciever.Move(direction);
        }
    }
}