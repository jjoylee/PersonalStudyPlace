using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11
{
    public class RemoteException : Exception
    {
        public RemoteException(string message, Exception cause) : base(message, cause) { }

        public RemoteException(string message) : base(message) { }
    }
}
