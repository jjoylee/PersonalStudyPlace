using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    public abstract class MenuComponent
    {
        public virtual void add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent getChild(int i)
        {
            throw new NotSupportedException();
        }

        public virtual string getName()
        {
            throw new NotSupportedException();
        }

        public virtual string getDescription()
        {
            throw new NotSupportedException();
        }

        public virtual double getPrice()
        {
            throw new NotSupportedException();
        }

        public virtual bool isVegetarian()
        {
            throw new NotSupportedException();
        }

        public virtual void print()
        {
            throw new NotSupportedException();
        }

        public virtual IEnumerator createEnumerator()
        {
            throw new NotSupportedException();
        }
    }
}
