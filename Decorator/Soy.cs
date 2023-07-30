namespace DesignPattern.Decorator
{
    internal class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return beverage.Cost() + .15;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", 두유";
        }
    }
}
