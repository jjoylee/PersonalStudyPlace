using System;

namespace Chapter5
{
    public class Stereo
    {
        string place;
        public Stereo(string place)
        {
            this.place = place;
        }
        internal void on()
        {
            Console.WriteLine(place + " : Turn On Stereo");
        }

        internal void setCD()
        {
            Console.WriteLine(place + " : Insert CD in Stereo");
        }

        internal void off()
        {
            Console.WriteLine(place + " : Turn Off Stereo");
        }

        internal void setVolume(int v)
        {
            Console.WriteLine(place + " : Set Stereo Volume " + v);
        }
    }
}