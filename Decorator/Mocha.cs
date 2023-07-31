namespace DesignPattern.Decorator
{
    internal class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            double cost = beverage.Cost();
            if(beverage.GetSize() == Size.TALL)
            {
                cost += .10;
            }
            else if(beverage.GetSize() == Size.GRANDE)
            {
                cost += .15;

            }
            else if (beverage.GetSize()== Size.VENTI)
            {
                cost += .20;
            }

            return cost;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", 모카";
        }
    }
}
