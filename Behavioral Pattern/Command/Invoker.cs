using UnityEngine;
namespace CommandPattern
{
    public class Invoker : MonoBehaviour
    {
        //Command
        private ICommand _command;
        //Set the command
        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        //Execute the command
        public void ExecuteCommand(Vector3 direction)
        {
            _command.Execute(direction);
        }
    }
}