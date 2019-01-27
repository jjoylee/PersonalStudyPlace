using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    public class TurkeyAdapter : Duck
    {
        Turkey turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }

        public void fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.fly();
            }
        }

        public void quack()
        {
            turkey.gobble();
        }
    }
}
