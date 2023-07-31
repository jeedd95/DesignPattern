namespace DesignPattern.Decorator
{
    internal abstract class Beverage
    {
        public string description = "제목 없음";

        public abstract double Cost();

        public virtual string GetDescription()
        {
            return description;
        }
    }
}
