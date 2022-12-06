//The Flyweight Factory creates and manages the flyweight objects. It ensures that flyweights are shared correctly. When the client requests a flyweight, the flyweight factory either returns an existing instance or creates a new one, if it doesn't exist yet.
using System.Collections.Generic;

namespace FlyweightPattern{
    public class FlyweightFactory{
        private Dictionary<string, IFlyweight> flyweights = new Dictionary<string, IFlyweight>();
        public IFlyweight GetFlyweight(string key){
            if(!flyweights.ContainsKey(key)){
                flyweights.Add(key, new ConcreteFlyweight());
            }
            return flyweights[key];
        }
        //Add a flyweight to the flyweight pool
        public void AddFlyweight(string name, IFlyweight flyweight){
            if(!flyweights.ContainsKey(name)){
                flyweights.Add(name, flyweight);
            }
        }
    }
}