namespace DesignPattern.Adapter
{
    internal class TurkeyAdapter : Duck
    {
        private Turkey turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }

        public void Fly()
        {
            turkey.Fly();
        }

        public void Quack()
        {
            turkey.Gobble();
        }
    }
}
