using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
{
    public interface Quackable : QuackObservable
    {
        void quack();
    }
}
