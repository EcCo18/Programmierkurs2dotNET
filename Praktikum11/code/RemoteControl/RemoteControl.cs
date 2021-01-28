using System;

namespace Programmierkurs2
{
    public class RemoteControl
    {
        private Command[,] commands;
        private readonly int commandsLength = 4;
        private readonly int onIndex = 0;
        private readonly int offIndex = 1;

        public RemoteControl()
        {
            commands = new Command[4, 2];
        }
        
        public void SetCommand(int i, Command on, Command off)
        {
            if (IsInRange(i))
            {
                commands[i, onIndex] = on;
                commands[i, offIndex] = off;
            }
            else
            {
                Console.WriteLine("!index out of bounds.");
            }
        }

        public void PressOn(int i)
        {
            if (IsInRange(i))
            {
                commands[i, onIndex].execute();
            }
        }

        public void PressOff(int i)
        {
            if (IsInRange(i))
            {
                commands[i, offIndex].execute();
            }
        }

        private bool IsInRange(int i)
        {
            return (i < commandsLength);
        }
    }
}