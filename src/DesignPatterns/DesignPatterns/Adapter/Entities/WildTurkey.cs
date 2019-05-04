using System;

namespace Adapter.Entities
{
    public class WildTurkey : Turkey
    {
        public override void Fly()
        {
            Console.WriteLine("I'm flying a short distance.");
        }

        public override void Gobble()
        {
            Console.WriteLine("Gobble gobble.");
        }
    }
}
