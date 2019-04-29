using Starbuzz.Infrastructure;

namespace Starbuzz.Entities
{
    public class DarkCoffee : Component
    {
        public DarkCoffee()
        {
            Description = "Dark Coffee";
        }

        public override decimal CalculateCost()
        {
            return 10;
        }
    }
}
