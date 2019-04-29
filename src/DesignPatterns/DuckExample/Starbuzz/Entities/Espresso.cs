using Starbuzz.Infrastructure;

namespace Starbuzz.Entities
{
    public class Espresso : Component
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override decimal CalculateCost()
        {
            return 13;
        }
    }
}
