namespace DesignPattern.Factory
{
    internal class SimplePizzaFactory
    {
        public Pizza CreatePizze(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese")) pizza = new PersimmonPizza();
            else if (type.Equals("pepperoni")) pizza = new GrapePizza();
            else if (type.Equals("clam")) pizza = new HurbPizza();
            else if (type.Equals("veggie")) pizza = new GochujangPizza();

            return pizza;
        }
    }
}
