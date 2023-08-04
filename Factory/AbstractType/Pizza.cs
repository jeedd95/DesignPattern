namespace DesignPattern.Factory.AbstractType
{
    internal abstract class Pizza
    {
        private string name;

        public Dough dough;
        public Cheese cheese;
        public Sause sause;
        public Veggies[] veggies;

        public abstract void Prepare();

        public void Bake()
        {

        }

        public void Cut()
        {

        }

        public void Box()
        {

        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
