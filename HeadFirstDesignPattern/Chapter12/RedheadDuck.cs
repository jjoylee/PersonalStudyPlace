using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
{
    public class RedheadDuck : Quackable
    {
        Observable observable;

        public RedheadDuck()
        {
            observable = new Observable(this);
        }
        public void notifyObservers()
        {
            observable.notifyObservers();
        }

        public void quack()
        {
            Console.WriteLine("Quack");
            notifyObservers();
        }

        public void registerObserver(Observer observer)
        {
            observable.registerObserver(observer);
        }
    }
}
