using System;
using RemoteControlCommand.Commands;
using RemoteControlCommand.Control;
using RemoteControlCommand.Entities;
using RemoteControlCommand.Enums;

namespace RemoteControlCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var control = new RemoteControl();

            var tv = new TV();
            var kitchenLight = new Light("Kitchen");
            var yardLight = new Light("Yard");

            control.SetCommand(Slot.Num0, new TVOnCommand(tv), new TVOffCommand(tv));
            control.SetCommand(Slot.Num1, new LightOnCommand(kitchenLight), new LightOffCommand(kitchenLight));
            control.SetCommand(Slot.Num2, new LightOnCommand(yardLight), new LightOffCommand(yardLight));

            Console.WriteLine(control.ToString() + '\n');

            control.OnButtonPressed(Slot.Num0);
            control.OffButtonPressed(Slot.Num0);

            control.OnButtonPressed(Slot.Num1);
            control.OffButtonPressed(Slot.Num1);

            control.OnButtonPressed(Slot.Num2);
            control.OffButtonPressed(Slot.Num2);

            Console.WriteLine('\n');

            control.UndoButtonPressed();
            control.UndoButtonPressed();
            control.UndoButtonPressed();

            Console.WriteLine('\n');

            control.OnButtonPressed(Slot.Num4);

            Console.ReadKey();
        }
    }
}
