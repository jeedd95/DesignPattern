namespace DesignPattern.Factory.AbstractType
{
    internal class SuwonPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sause CreateSause()
        {
            return new MarinaraSauce();
        }

        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new Onion(), new Garlic(), new Mushroom() };
            return veggies;
        }
    }
}
