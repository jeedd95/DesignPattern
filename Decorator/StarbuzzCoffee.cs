using System;

namespace DesignPattern.Decorator
{
    internal class StarbuzzCoffee
    {
        public static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + " $ " + beverage.Cost());

            Beverage beverage2 = new Espresso();
            beverage2 = new Mocha(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " $ " + beverage2.Cost());

            Beverage beverage3 = new Espresso();
            beverage3 = new Soy(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " $ " + beverage3.Cost());

        }
    }
}
