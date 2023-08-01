using System;
using System.Collections.Generic;

namespace DesignPattern.Factory
{
    /// <summary>
    /// 제품 클래스
    /// </summary>
    internal abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;
        public List<string> toppings = new List<string>();
        public string GetName { get => name; }

        public virtual void Prepare()
        {
            Console.WriteLine($"준비 중 : {name}");
            Console.WriteLine($"도우를 돌리는 중...");
            Console.WriteLine($"소스를 뿌리는 중...");
            Console.WriteLine($"토핑을 올리는 중...");
            foreach (var topping in toppings)
            {
                Console.WriteLine(" " + topping);
            }
        }
        public virtual void Bake()
        {
            Console.WriteLine("굽기");
        }
        public virtual void Cut()
        {
            Console.WriteLine("자르기");
        }
        public virtual void Box()
        {
            Console.WriteLine("포장");
        }
    }
}