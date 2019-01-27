using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    public class StereoOnWithCDCommand : Command
    {
        Stereo stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.on();
            stereo.setCD();
            stereo.setVolume(11);
        }

        public void undo()
        {
            stereo.off();
        }
    }
}
