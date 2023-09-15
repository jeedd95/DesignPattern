using System.Collections.Generic;

namespace DesignPattern.Iterator
{
    internal class PancakeHouseMenu
    {
        private List<MenuItem> menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();
        }

        public List<MenuItem> GetMenuItems()
        {
            return menuItems;
        }
    }

    internal class PancakeHouseMenuIterator : Iterator
    {
        private List<MenuItem> items;
        private int position;

        public PancakeHouseMenuIterator(List<MenuItem> menuItems)
        {
            this.items = menuItems;
        }

        public bool hasNext()
        {
            if (position >= items.Count || items[position] == null)
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
            MenuItem item = items[position];
            position++;
            return item;
        }
    }
}
