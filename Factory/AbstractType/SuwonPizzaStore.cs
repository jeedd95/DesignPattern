namespace DesignPattern.Factory.AbstractType
{
    internal class SuwonPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            PizzaIngredientFactory pizzaIngredientFactory = new SuwonPizzaIngredientFactory();

            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(pizzaIngredientFactory);
                pizza.SetName("치즈 피자");
            }

            return pizza;
        }
    }
}
