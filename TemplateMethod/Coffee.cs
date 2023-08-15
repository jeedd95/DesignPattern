using System;

namespace DesignPattern.TemplateMethod
{
    internal class Coffee : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            throw new NotImplementedException();
        }

        public override void Brew()
        {
            throw new NotImplementedException();
        }

    }
}
