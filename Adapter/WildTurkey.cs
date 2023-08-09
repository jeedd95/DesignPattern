using System;

namespace DesignPattern.Adapter
{
    internal class WildTurkey : Turkey
    {
        public void Fly()
        {
            Console.WriteLine("짧은 거리 날기");
        }

        public void Gobble()
        {
            Console.WriteLine("골골");
        }
    }
}
