namespace DesignPattern.Composite
{
    internal class MenuItem : MenuComponent
    {
        string name;
        string description;
        bool vegeterian;
        double price;

        public MenuItem(string name, string description, bool vegeterian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegeterian = vegeterian;
            this.price = price;
        }

        public override string getName()
        {
            return name;
        }

        public override string getDescription()
        {
            return description;
        }

        public override double getPrice()
        {
            return price;
        }

        public override bool isVegeterain()
        {
            return vegeterian;
        }

    }
}
