using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    public class CeilingFan
    {
        string place;
        public CeilingFan(string place)
        {
            this.place = place;
        }

        internal void on()
        {
            Console.WriteLine(place + " ceiling fan is on high");
        }

        internal void off()
        {
            Console.WriteLine(place + " ceiling fan is off");
        }
    }
}
