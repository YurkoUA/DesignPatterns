using System;

namespace RemoteControlCommand.Entities
{
    public class Light
    {
        private readonly string location;

        public Light(string location)
        {
            this.location = location;
        }

        public void On()
        {
            Console.WriteLine($"Light '{location}' is on.");
        }

        public void Off()
        {
            Console.WriteLine($"Light '{location}' is off.");
        }
    }
}
