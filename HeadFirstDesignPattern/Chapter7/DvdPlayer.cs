using System;

namespace Chapter7
{
    public class DvdPlayer
    {
        internal void on()
        {
            Console.WriteLine("Turn on dvd player");
        }

        internal void play(string movie)
        {
            Console.WriteLine("Play dvd player");
        }

        internal void stop()
        {
            Console.WriteLine("Stop dvd player");
        }

        internal void eject()
        {
            Console.WriteLine("eject dvd player");
        }

        internal void off()
        {
            Console.WriteLine("turn off dvd player");
        }
    }
}