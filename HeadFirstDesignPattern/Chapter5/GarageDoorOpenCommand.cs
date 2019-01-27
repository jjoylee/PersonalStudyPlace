using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    public class GarageDoorOpenCommand : Command
    {
        GarageDoor garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void execute()
        {
            garageDoor.open();
        }

        public void undo()
        {
            garageDoor.close();
        }
    }
}
