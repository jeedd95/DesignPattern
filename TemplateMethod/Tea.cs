using System;

namespace DesignPattern.TemplateMethod
{
    internal class Tea : CaffeineBeverage
    {
        public override void AddCondiments()
        {
        }

        public override void Brew()
        {
        }

        public override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();

            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetUserInput()
        {
            string answer = null;
            Console.WriteLine($"커피에 우유와 설탕을 넣을까요? y/n");
            answer = Console.ReadLine();
            if (answer == null) return "no";
            return answer;
        }
    }
}
