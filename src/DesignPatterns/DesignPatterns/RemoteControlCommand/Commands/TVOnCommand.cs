using RemoteControlCommand.Entities;
using RemoteControlCommand.Interfaces;

namespace RemoteControlCommand.Commands
{
    public class TVOnCommand : ICommand
    {
        private readonly TV tv;

        public TVOnCommand(TV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.On();
            tv.SetVolume(20);
        }

        public void Undo()
        {
            tv.Off();
        }
    }
}
