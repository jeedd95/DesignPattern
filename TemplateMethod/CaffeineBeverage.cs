namespace DesignPattern.TemplateMethod
{
    internal abstract class CaffeineBeverage
    {
        /// <summary>
        /// 템플릿 메소드
        /// </summary>
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public abstract void Brew();
        public abstract void AddCondiments();

        private void BoilWater()
        {

        }

        private void PourInCup()
        {

        }

        /// <summary>
        /// 후크
        /// </summary>
        /// <returns></returns>
        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}
