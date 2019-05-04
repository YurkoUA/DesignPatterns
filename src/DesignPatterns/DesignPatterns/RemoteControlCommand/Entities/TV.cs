using System;

namespace RemoteControlCommand.Entities
{
    public class TV
    {
        public void On()
        {
            Console.WriteLine("TV is on.");
        }

        public void Off()
        {
            Console.WriteLine("TV is off.");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Volume is set to {volume}.");
        }
    }
}
