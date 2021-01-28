using System;

namespace Programmierkurs2
{
    class Program
    {
        static void Main(string[] args)
        {
            CdPlayer player = new CdPlayer();
            Garagentor garagentor = new Garagentor();
            RemoteControl remoteControl = new RemoteControl();

            CdStart cdStart = new CdStart(player);
            CdStop cdStop = new CdStop(player);

            GaragentorHoch garagentorHoch = new GaragentorHoch(garagentor);
            GaragentorRunter garagentorRunter = new GaragentorRunter(garagentor);
            
            remoteControl.SetCommand(0, cdStart, cdStop);
            
            remoteControl.SetCommand(1, garagentorHoch, garagentorRunter);
            
            remoteControl.PressOn(0);
            remoteControl.PressOn(1);
            
            remoteControl.PressOff(0);
            remoteControl.PressOff(1);
        }
    }
}