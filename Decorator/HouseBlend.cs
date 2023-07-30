namespace DesignPattern.Decorator
{
    internal class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "하우스 블렌드 커피";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
