//The Command acts as an interface for all commands.
using UnityEngine;
namespace CommandPattern
{
    //This command will be expecting some direction in as a Vector3
    public interface ICommand
    {
        void Execute(Vector3 direction);
    }
}