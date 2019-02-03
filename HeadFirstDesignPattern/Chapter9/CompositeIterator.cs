using System;
using System.Collections;

namespace Chapter9
{
    public class CompositeEnumerator : IEnumerator
    {
        Stack stack = new Stack();

        public CompositeEnumerator(IEnumerator enumerator)
        {
            stack.Push(enumerator);
        }

        public object Current
        {
            get
            {
                if (MoveNext())
                {
                    IEnumerator enumerator = (IEnumerator)stack.Peek();
                    MenuComponent component = (MenuComponent)enumerator.Current;
                    if (component is Menu) stack.Push(component.createEnumerator());
                    return component;
                }
                else return null;
            }
        }

        public bool MoveNext()
        {
            if (stack.Count == 0) return false;

            IEnumerator enumerator = (IEnumerator)stack.Peek();
            if (!enumerator.MoveNext())
            {
                stack.Pop();
                return MoveNext();
            }
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}