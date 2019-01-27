using System;

namespace Chapter5
{
    internal class NoCommand : Command
    {
        public void execute()
        {
            Console.WriteLine("NoCommand");
        }

        public void undo()
        {
            Console.WriteLine("NoCommand");
        }
    }
}