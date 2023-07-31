using System;

namespace DesignPattern.Decorator
{
    internal class StarbuzzCoffee
    {
        public static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            beverage.SetSize(Beverage.Size.GRANDE);
            beverage = new Mocha(beverage); //사이즈에 따른 계산을 첨가물에서 하기때문에 사이즈를 적용한다음 실행해야한다
            Console.WriteLine(beverage.GetDescription() + " $ " + beverage.Cost());

            //Beverage beverage2 = new Espresso();
            //beverage2 = new Mocha(beverage2);
            //Console.WriteLine(beverage2.GetDescription() + " $ " + beverage2.Cost());

            //Beverage beverage3 = new Espresso();
            //beverage3 = new Soy(beverage3);
            //beverage3 = new Whip(beverage3);
            //Console.WriteLine(beverage3.GetDescription() + " $ " + beverage3.Cost());

        }
    }
}
