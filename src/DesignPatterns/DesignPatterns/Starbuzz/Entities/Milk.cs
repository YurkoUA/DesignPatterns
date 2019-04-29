using Starbuzz.Infrastructure;

namespace Starbuzz.Entities
{
    public class Milk : CondimentDecorator
    {
        public Milk(Component component) : base(component)
        {
            Description = component.Description + ", Milk";
        }

        public override decimal CalculateCost()
        {
            return component.CalculateCost() + 0.3m;
        }
    }
}
