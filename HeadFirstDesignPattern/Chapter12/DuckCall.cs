using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
{
    public class DuckCall : Quackable
    {
        Observable observable;

        public DuckCall()
        {
            observable = new Observable(this);
        }
        public void notifyObservers()
        {
            observable.notifyObservers();
        }

        public void quack()
        {
            Console.WriteLine("Kwak");
            notifyObservers();
        }

        public void registerObserver(Observer observer)
        {
            observable.registerObserver(observer);
        }
    }
}
