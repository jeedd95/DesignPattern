namespace DesignPattern.Decorator
{
    internal abstract class Beverage
    {
        public enum Size { TALL, GRANDE,VENTI };
        Size size  = Size.TALL;
        public string description = "제목 없음";

        public abstract double Cost();

        public virtual string GetDescription()
        {
            return description;
        }

        public void SetSize(Size size)
        {
            this.size = size;
        }

        public Size GetSize()
        {
            return this.size;
        }
    }
}
