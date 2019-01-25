using System;
using HeadFirstDesignPatterns.Command;

namespace DesignPatternsConsoleClient.HeadFirstDesignPatterns.Command
{
    // Client in Command Pattern
    public class RemoteControlSimulator
    {
        public static void Start()
        {
            // SimpleRemoteControl example
            //SimpleRemoteControl remote = new SimpleRemoteControl();

            //Light light = new Light();
            //LightOnCommand lightOn = new LightOnCommand(light);

            //GarageDoor garageDoor = new GarageDoor();
            //GarageDoorOpenCommand garageOpen = new GarageDoorOpenCommand(garageDoor);

            //remote.SetCommand(lightOn);
            //remote.ButtonWasPressed();

            //remote.SetCommand(garageOpen);
            //remote.ButtonWasPressed();

            // RemoteControl example
            //RemoteControl remoteControl = new RemoteControl();
            //Light livingRoomLight = new Light("Living Room");
            //Light kitchenLight = new Light("Kitchen");
            //CeilingFan ceilingFan = new CeilingFan("Living Room");
            //GarageDoor garageDoor = new GarageDoor();
            //Stereo stereo = new Stereo("Living Room");

            //LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            //LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            //LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            //LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            //CeilingFanOnCommand ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            //CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            //GarageDoorOpenCommand garageDoorUp = new GarageDoorOpenCommand(garageDoor);
            //GarageDoorCloseCommand garageDoorDown = new GarageDoorCloseCommand(garageDoor);

            //StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            //StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            //remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            //remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            //remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
            //remoteControl.SetCommand(3, stereoOnWithCD, stereoOff);

            //Console.WriteLine(remoteControl);

            //remoteControl.OnButtonWasPushed(0);
            //remoteControl.OffButtonWasPushed(0);
            //remoteControl.OnButtonWasPushed(1);
            //remoteControl.OffButtonWasPushed(1);
            //remoteControl.OnButtonWasPushed(2);
            //remoteControl.OffButtonWasPushed(2);
            //remoteControl.OnButtonWasPushed(3);
            //remoteControl.OffButtonWasPushed(3);

            // MacroCommand Example
            RemoteControl remoteControl = new RemoteControl();

            Light light = new Light("Living Room");
            TV tv = new TV("Living Room");
            Stereo stereo = new Stereo("Living Room");
            Hottub hottub = new Hottub();

            LightOnCommand lightOn = new LightOnCommand(light);
            StereoOnCommand stereoOn = new StereoOnCommand(stereo);
            TVOnCommand tvOn = new TVOnCommand(tv);
            HottubOnCommand hottubOn = new HottubOnCommand(hottub);

            LightOffCommand lightOff = new LightOffCommand(light);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);
            TVOffCommand tvOff = new TVOffCommand(tv);
            HottubOffCommand hottubOff = new HottubOffCommand(hottub);

            ICommand[] partyOn = { lightOn, stereoOn, tvOn, hottubOn };
            ICommand[] partyOff = { lightOff, stereoOff, tvOff, hottubOff };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);

            Console.WriteLine(remoteControl);
            Console.WriteLine("---Pushing Macro On---");

            remoteControl.OnButtonWasPushed(0);

            Console.WriteLine("---Pushing Macro Off---");

            remoteControl.OffButtonWasPushed(0);
        }
    }
}