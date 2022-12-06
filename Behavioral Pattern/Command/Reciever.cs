//The Reciever is the one that will be executing the command.
using UnityEngine;
namespace CommandPattern
{
    public class Reciever : MonoBehaviour
    {
        public void Move(Vector3 direction)
        {
            transform.position += direction;
        }
    }
}