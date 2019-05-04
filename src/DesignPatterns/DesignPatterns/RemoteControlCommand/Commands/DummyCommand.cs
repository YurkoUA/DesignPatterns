using System;
using RemoteControlCommand.Interfaces;

namespace RemoteControlCommand.Commands
{
    public class DummyCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Unable to execute: command doesn't exist.");
        }

        public void Undo()
        {
            Console.WriteLine("Unable to undo: command doesn't exist.");
        }
    }
}
