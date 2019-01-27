using System;

namespace Chapter7
{
    public class Amplifier
    {
        internal void on()
        {
            Console.WriteLine("turn on amplifier");
        }

        internal void setDvd(DvdPlayer dvd)
        {
            Console.WriteLine("set dvd player");
        }

        internal void setSurroundSound()
        {
            Console.WriteLine("set surround sound");
        }

        internal void setVolume(int v)
        {
            Console.WriteLine("set amp volume to " + v);
        }

        internal void off()
        {
            Console.WriteLine("turn off the amp");
        }
    }
}