using System;

namespace DesignPattern.Factory.SimpleType
{
    public class Pizza
    {
        public void Prepare()
        {
            Console.WriteLine("준비");
        }

        public void Bake()
        {
            Console.WriteLine("굽기");
        }

        public void Cut()
        {
            Console.WriteLine("자르기");
        }

        public void Box()
        {
            Console.WriteLine("포장하기");
        }
    }
}