﻿namespace DesignPattern.Decorator
{
    internal class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return beverage.Cost() + .10;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", 휘핑크림";
        }
    }
}
