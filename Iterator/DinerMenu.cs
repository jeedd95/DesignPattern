using System.Collections.Generic;

namespace DesignPattern.Iterator
{
    internal class DinerMenu
    {
        private const int MAX_ITEMS = 6;
        private MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];
        }

        public MenuItem[] GetMenuItems()
        {
            return menuItems;
        }

        public Iterator CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
    }

    internal class DinerMenuIterator : Iterator
    {
        private MenuItem[] items;
        private int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public bool hasNext()
        {
            if (position >= items.Length || items[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public MenuItem next()
        {
            MenuItem menuItem = items[position];
            position++;
            return menuItem;
        }
    }
}
