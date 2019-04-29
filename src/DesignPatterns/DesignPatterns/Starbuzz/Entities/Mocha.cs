using Starbuzz.Infrastructure;

namespace Starbuzz.Entities
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Component component) : base(component)
        {
            Description = component.Description + ", Mocha";
        }

        public override decimal CalculateCost()
        {
            return component.CalculateCost() + 0.5m;
        }
    }
}
