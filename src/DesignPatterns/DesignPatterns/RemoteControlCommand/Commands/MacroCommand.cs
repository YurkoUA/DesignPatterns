using RemoteControlCommand.Interfaces;

namespace RemoteControlCommand.Commands
{
    public class MacroCommand : ICommand
    {
        private readonly ICommand[] commands;

        public MacroCommand(params ICommand[] commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            for (var i = 0; i < commands.Length; i++)
            {
                commands[i].Execute();
            }
        }

        public void Undo()
        {
            for (var i = commands.Length - 1; i >= 0; i--)
            {
                commands[i].Undo();
            }
        }
    }
}
