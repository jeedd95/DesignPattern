using System;

namespace DesignPattern.Command
{
    internal class Light
    {
        public void On()
        {
            Console.WriteLine("버튼 켜짐");
        }

        public void Off()
        {
            Console.WriteLine("버튼 꺼짐");
        }
    }
}