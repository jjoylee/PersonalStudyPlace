using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
{
    public class Flock : Quackable
    {
        ArrayList quackers = new ArrayList();

        public void add(Quackable quacker)
        {
            quackers.Add(quacker);
        }

        public void notifyObservers()
        {
            throw new NotImplementedException();
        }

        public void quack()
        {
            IEnumerator enumerator = quackers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Quackable quacker = (Quackable)enumerator.Current;
                quacker.quack();
            }
        }

        public void registerObserver(Observer observer)
        {
            IEnumerator enumerator = quackers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Quackable quacker = (Quackable)enumerator.Current;
                quacker.registerObserver(observer);
            }
        }

        internal void add(Flock floackOfMallards)
        {
            quackers.AddRange(floackOfMallards.quackers);
        }
    }
}
