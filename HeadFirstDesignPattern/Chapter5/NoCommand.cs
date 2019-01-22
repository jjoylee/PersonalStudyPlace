using System;

namespace Chapter5
{
    internal class NoCommand : Command
    {
        public void execute()
        {
            Console.WriteLine("NoCommand");
        }
    }
}