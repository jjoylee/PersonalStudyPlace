using System;
using System.Collections;

namespace Chapter9
{
    internal class NullEnumerator : IEnumerator
    {
        public object Current
        {
            get
            {
                return null;
            }
        }

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
            throw new NotSupportedException();
        }
    }
}