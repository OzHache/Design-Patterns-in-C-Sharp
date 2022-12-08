//The Concrete Subject contains some important state and notifies observers when the state changes.
//observer as a monobeaviour
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Subject : MonoBehaviour, ISubject {
    private double _price;
    private List<IObserver> _observers = new List<IObserver>();
    public double Price {
        get { return _price; }
        set {
            if (_price != value) {
                _price = value;
                Notify();
            }
        }
    }
    public void Attach(IObserver observer) {
        _observers.Add(observer);
    }
    public void Detach(IObserver observer) {
        _observers.Remove(observer);
    }
    public void Notify() {
        foreach (IObserver observer in _observers) {
            observer.Update(this);
        }
    }
}