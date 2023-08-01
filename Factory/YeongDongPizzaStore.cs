namespace DesignPattern.Factory
{
    internal class YeongDongPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            if (type.Equals("곶감")) return new PersimmonPizza();
            else if (type.Equals("포도")) return new GrapePizza();
            else if (type.Equals("나물")) return new HurbPizza();
            else if (type.Equals("고추장")) return new GochujangPizza();
            else return null;
        }
    }
}
