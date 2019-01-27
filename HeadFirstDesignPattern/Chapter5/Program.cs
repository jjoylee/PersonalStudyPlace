using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Program
    {
        //Command Pattern

        // 작업을 요청한 쪽과 작업을 처리한 쪽을 분리
        // 커맨드 객체가 특정 캑체에 대한 특정 작업 요청을 캡슐화
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();
            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor("");
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanOnCommand ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remote.setCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.setCommand(1, kitchenLightOn, kitchenLightOff);
            remote.setCommand(2, ceilingFanOn, ceilingFanOff);
            remote.setCommand(3, stereoOnWithCD, stereoOff);

            Console.WriteLine(remote);

            remote.onButtonWasPushed(0);
            remote.offButtonWasPushed(0);
            remote.undoButtonWasPushed();
            remote.onButtonWasPushed(1);
            remote.offButtonWasPushed(1);
            remote.undoButtonWasPushed();
            remote.onButtonWasPushed(2);
            remote.offButtonWasPushed(2);
            remote.undoButtonWasPushed();
            remote.onButtonWasPushed(3);
            remote.offButtonWasPushed(3);
            remote.undoButtonWasPushed();

            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);

            remote.setCommand(4, ceilingFanMedium, ceilingFanOff);
            remote.setCommand(5, ceilingFanHigh, ceilingFanOff);

            remote.onButtonWasPushed(4);
            remote.offButtonWasPushed(4);
            remote.undoButtonWasPushed();

            remote.onButtonWasPushed(5);
            remote.undoButtonWasPushed();

            // MacroCommand

            Command[] partyOn = { livingRoomLightOn, stereoOnWithCD, ceilingFanOn };
            Command[] partyOff = { livingRoomLightOff, stereoOff, ceilingFanOff };
            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);
            remote.setCommand(6, partyOnMacro, partyOffMacro);

            Console.WriteLine("------ Macro Start ------");
            remote.onButtonWasPushed(6);
            remote.offButtonWasPushed(6);
        }
    }
}
