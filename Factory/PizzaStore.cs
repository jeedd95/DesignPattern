namespace DesignPattern.Factory
{
    /// <summary>
    /// 생산자 클래스
    /// </summary>
    internal abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(string type);

        public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
