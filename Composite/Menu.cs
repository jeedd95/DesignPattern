using System.Collections.Generic;

namespace DesignPattern.Composite
{
    internal class Menu : MenuComponent
    {
        List<MenuComponent> menuComponents = new List<MenuComponent>();
        string name;
        string decription;

        public Menu(string name, string decription)
        {
            this.name = name;
            this.decription = decription;
        }

        public override void add(MenuComponent menuComponent)
        {
            this.menuComponents.Add(menuComponent);
        }

        public override void print()
        {
            foreach(MenuComponent menuComponent in menuComponents)
            {
                menuComponent.print();
            }
        }
    }
}
