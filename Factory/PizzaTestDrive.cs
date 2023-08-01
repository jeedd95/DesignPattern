using System;

namespace DesignPattern.Factory
{
    internal class PizzaTestDrive
    {
        public static void Main()
        {
            PizzaStore pizzaStore = new YeongDongPizzaStore();
            Pizza pizza = pizzaStore.OrderPizza("곶감");
            Console.WriteLine($"고객님이 주문한 {pizza.GetName}");
        }
    }
}
