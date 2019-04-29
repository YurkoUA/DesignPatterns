using Starbuzz.Infrastructure;

namespace Starbuzz.Entities
{
    public class BlackTea : Component
    {
        public BlackTea()
        {
            Description = "Black Tea";
        }

        public override decimal CalculateCost()
        {
            return 6;
        }
    }
}
