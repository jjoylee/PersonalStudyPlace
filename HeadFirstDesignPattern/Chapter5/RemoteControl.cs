using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    public class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;
        Command undoCommand;

        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];

            Command noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = noCommand;
        }

        // Invoker
        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPushed(int slot)
        {
            if(onCommands[slot] != null)
            {
                onCommands[slot].execute();
                undoCommand = onCommands[slot];
            }
        }

        public void offButtonWasPushed(int slot)
        {
            if(offCommands[slot] != null)
            {
                offCommands[slot].execute();
                undoCommand = offCommands[slot];
            }
        }

        public void undoButtonWasPushed()
        {
            undoCommand.undo();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("------ Remote Control ------");
            for(int i = 0;i < 7; i++)
            {
                builder.Append("[slot " + i + "] " + onCommands[i].GetType() + "    ");
                builder.AppendLine(offCommands[i].GetType().Name);
            }
            return builder.ToString();
        }
    }
}
