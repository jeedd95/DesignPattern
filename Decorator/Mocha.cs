﻿namespace DesignPattern.Decorator
{
    internal class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return beverage.Cost() + .20;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", 모카";
        }
    }
}
