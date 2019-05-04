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
            var livingRoomLight = new Light("Living Room");
            var bathroomLight = new Light("Bathroom");
            var bedroomLight = new Light("Bedroom");

            var lightOnKitchen = new LightOnCommand(kitchenLight);
            var lightOnYard = new LightOnCommand(yardLight);
            var lightOnLivingR = new LightOnCommand(livingRoomLight);
            var lightOnBathR = new LightOnCommand(bathroomLight);
            var lightOnBedR = new LightOnCommand(bedroomLight);

            var lightOffKitchen = new LightOffCommand(kitchenLight);
            var lightOffYard = new LightOffCommand(yardLight);
            var lightOffLivingR = new LightOffCommand(livingRoomLight);
            var lightOffBathR = new LightOffCommand(bathroomLight);
            var lightOffBedR = new LightOffCommand(bedroomLight);

            control.SetCommand(Slot.Num0, new TVOnCommand(tv), new TVOffCommand(tv));
            control.SetCommand(Slot.Num1, lightOnKitchen, lightOffKitchen);
            control.SetCommand(Slot.Num2, lightOnYard, lightOffYard);

            control.SetCommand(Slot.Num3, 
                new MacroCommand(lightOnKitchen, lightOnYard, lightOnLivingR, lightOnBathR, lightOnBedR), 
                new MacroCommand(lightOffKitchen, lightOffYard, lightOffLivingR, lightOffBathR, lightOffBedR));

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

            Console.WriteLine('\n');

            control.OnButtonPressed(Slot.Num3);
            control.UndoButtonPressed();

            Console.ReadKey();
        }
    }
}
