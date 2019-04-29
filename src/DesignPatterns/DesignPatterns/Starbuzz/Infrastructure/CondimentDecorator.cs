namespace Starbuzz.Infrastructure
{
    public abstract class CondimentDecorator : Component
    {
        protected Component component;

        public CondimentDecorator(Component component)
        {
            this.component = component;
        }
    }
}
