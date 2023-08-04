namespace DesignPattern.Factory.AbstractType
{
    internal interface PizzaIngredientFactory
    {
        Dough CreateDough();
        Sause CreateSause();
        Cheese CreateCheese();
        Veggies[] CreateVeggies();
    }
}
