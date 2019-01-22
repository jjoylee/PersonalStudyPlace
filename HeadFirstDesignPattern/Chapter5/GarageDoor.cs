using System;

namespace Chapter5
{
    public class GarageDoor
    {
        string place;

        public GarageDoor(string place)
        {
            this.place = place;
        }

        internal void open()
        {
            Console.WriteLine(place + " Open the garage door");
        }
    }
}