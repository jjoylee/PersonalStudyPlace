using System;

namespace Chapter5
{
    public class Light
    {
        string place;
        public Light(string place)
        {
            this.place = place;
        }

        internal void on()
        {
            Console.WriteLine(place + " Light is On");
        }

        internal void off()
        {
            Console.WriteLine(place + " Light is Off");
        }
    }
}