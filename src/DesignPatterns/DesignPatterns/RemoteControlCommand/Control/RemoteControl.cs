using System.Collections.Generic;
using System.Linq;
using System.Text;
using RemoteControlCommand.Commands;
using RemoteControlCommand.Enums;
using RemoteControlCommand.Interfaces;

namespace RemoteControlCommand.Control
{
    public class RemoteControl
    {
        const int SLOTS_COUNT = 7;

        private readonly ICommand[] onCommands;
        private readonly ICommand[] offCommands;
        private readonly Stack<ICommand> executedCommands;

        public RemoteControl()
        {
            executedCommands = new Stack<ICommand>();
            onCommands = new ICommand[SLOTS_COUNT];
            offCommands = new ICommand[SLOTS_COUNT];

            for (var i = 0; i < SLOTS_COUNT; i++)
            {
                onCommands[i] = new DummyCommand();
                offCommands[i] = new DummyCommand();
            }
        }

        public void SetCommand(Slot slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[(int)slot] = onCommand;
            offCommands[(int)slot] = offCommand;
        }

        public void OnButtonPressed(Slot slot)
        {
            var command = onCommands[(int)slot];
            command.Execute();
            executedCommands.Push(command);
        }

        public void OffButtonPressed(Slot slot)
        {
            var command = offCommands[(int)slot];
            command.Execute();
            executedCommands.Push(command);
        }

        public void UndoButtonPressed()
        {
            var command = executedCommands.Pop();
            command?.Undo();
        }

        public override string ToString()
        {
            var sBuilder = new StringBuilder();

            for (var i = 0; i < SLOTS_COUNT; i++)
            {
                var on = onCommands[i].GetType().ToString().Split('.').Last();
                var off = offCommands[i].GetType().ToString().Split('.').Last();

                sBuilder.AppendLine($"SLOT {i}. On: {on}. Off: {off}.");
            }

            return sBuilder.ToString();
        }
    }
}
