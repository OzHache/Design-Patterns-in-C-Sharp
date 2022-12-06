//The Client is the one that will be used to create the Mediator.
namespace Mediator_Pattern
{
using UnityEngine;

    public class Client : MonoBehaviour {
        private void Start()
        {
            Mediator mediator = new ConcreteMediator();
            Colleague colleague1 = new ConcreteColleague1(mediator);
            Colleague colleague2 = new ConcreteColleague2(mediator);
            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;
            colleague1.Send("How are you?");
            colleague2.Send("Fine, thanks");
        }
    }
}