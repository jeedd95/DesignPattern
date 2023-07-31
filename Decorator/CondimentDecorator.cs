namespace DesignPattern.Decorator
{
    internal abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;

        public abstract override string GetDescription();
    }
}
