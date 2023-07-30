namespace DesignPattern.Decorator
{
    internal abstract class Beverage
    {
        protected string description = "제목 없음";

        public abstract double Cost();

        public string GetDescription()
        {
            return description;
        }
    }
}
