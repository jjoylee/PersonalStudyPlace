using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    public class MacroCommand : Command
    {
        Command[] commands;
        
        public MacroCommand(Command[] commands)
        {
            this.commands = commands;
        }

        public void execute()
        {
            foreach(Command command in commands)
            {
                command.execute();
            }
        }

        public void undo()
        {
            foreach (Command command in commands)
            {
                command.undo();
            }
        }
    }
}
