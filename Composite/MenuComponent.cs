using System;

namespace DesignPattern.Composite
{
    internal abstract class MenuComponent
    {
        public virtual void add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public virtual void remove(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public virtual MenuComponent getChild(int index)
        {
            throw new NotImplementedException();
        }

        public virtual string getName()
        {
            throw new NotImplementedException();
        }

        public virtual string getDescription()
        {
            throw new NotImplementedException();
        }

        public virtual double getPrice()
        {
            throw new NotImplementedException();
        }

        public virtual bool isVegeterain()
        {
            throw new NotImplementedException();
        }

        public virtual void print()
        {
            throw new NotImplementedException();
        }
    }
}
