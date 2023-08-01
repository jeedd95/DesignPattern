using System;

namespace DesignPattern.Factory
{
    internal class PersimmonPizza : Pizza
    {
        public PersimmonPizza()
        {
            name = "영동 스타일 소스와 곶감 피자";
            dough = "통 호밀 도우";
            sauce = "멸치액젓 소스";

            toppings.Add("슬라이스 애호박");
        }

        public override void Cut()
        {
            Console.WriteLine("새로운 방법으로 자르기");
        }
    }
}