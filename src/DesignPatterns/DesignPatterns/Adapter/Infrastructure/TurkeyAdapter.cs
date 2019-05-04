using Adapter.Entities;

namespace Adapter.Infrastructure
{
    public class TurkeyAdapter : Duck
    {
        public readonly Turkey turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }

        public override void Fly()
        {
            for (var i = 0; i < 5; i++)
            {
                turkey.Fly();
            }
        }

        public override void Quack()
        {
            turkey.Gobble();
        }
    }
}
