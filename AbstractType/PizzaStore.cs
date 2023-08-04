namespace DesignPattern.Factory.AbstractType
{
    internal abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(string item);
    }
}
