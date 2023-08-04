namespace DesignPattern.Factory.AbstractType
{
    internal class CheesePizza : Pizza
    {
        private PizzaIngredientFactory ingredientFactory;

        public CheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory=ingredientFactory;
        }

        public override void Prepare()
        {
            dough = ingredientFactory.CreateDough();
            sause = ingredientFactory.CreateSause();
            veggies = ingredientFactory.CreateVeggies();
            cheese = ingredientFactory.CreateCheese();
        }
    }
}
