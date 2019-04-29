using Starbuzz.Infrastructure;

namespace Starbuzz.Entities
{
    public class Lemon : CondimentDecorator
    {
        public Lemon(Component component) : base(component)
        {
            Description = component.Description + ", Lemon";
        }

        public override decimal CalculateCost()
        {
            return component.CalculateCost() + 0.25m;
        }
    }
}
