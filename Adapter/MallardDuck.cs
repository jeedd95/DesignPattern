namespace DesignPattern.Adapter
{
    internal class MallardDuck : Duck
    {
        public void Fly()
        {
            throw new System.NotImplementedException();
        }

        public void Quack()
        {
            throw new System.NotImplementedException();
        }
    }
}
