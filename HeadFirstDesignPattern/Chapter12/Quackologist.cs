using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
{
    public class Quackologist : Observer
    {
        public void update(QuackObservable duck)
        {
            Console.WriteLine("Quackologist: " + duck + " just quacked ");
        }
    }
}
