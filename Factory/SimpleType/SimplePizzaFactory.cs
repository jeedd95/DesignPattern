using System;

namespace DesignPattern.Factory.SimpleType
{
    internal class SimplePizzaFactory
    {
        internal Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese")) pizza = new CheesePizza();
            if (type.Equals("pepperoni")) pizza = new Pepperoni();

            return pizza;
        }
    }
}