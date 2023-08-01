namespace DesignPattern.Decorator
{
    internal class Espresso : Beverage
    {
        public Espresso()
        {
            description = "에스프레소";
        }

        public override double Cost()
        {
            return 1.99;
        }

    }
}
