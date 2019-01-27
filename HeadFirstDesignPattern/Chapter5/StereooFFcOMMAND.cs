using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    public class StereoOffCommand : Command
    {
        Stereo stereo;
        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void execute()
        {
            stereo.off();
        }

        public void undo()
        {
            stereo.on();
            stereo.setCD();
            stereo.setVolume(11);
        }
    }
}
