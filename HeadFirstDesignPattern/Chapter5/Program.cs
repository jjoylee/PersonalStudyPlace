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

            LightOnCommand livingRoolLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoolLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanOnCommand ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remote.setCommand(0, livingRoolLightOn, livingRoolLightOff);
            remote.setCommand(1, kitchenLightOn, kitchenLightOff);
            remote.setCommand(2, ceilingFanOn, ceilingFanOff);
            remote.setCommand(3, stereoOnWithCD, stereoOff);

            Console.WriteLine(remote);

            remote.onButtonWasPushed(0);
            remote.offButtonWasPushed(0);
            remote.onButtonWasPushed(1);
            remote.offButtonWasPushed(1);
            remote.onButtonWasPushed(2);
            remote.offButtonWasPushed(2);
            remote.onButtonWasPushed(3);
            remote.offButtonWasPushed(3);

        }
    }
}
