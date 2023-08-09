namespace DesignPattern.Adapter
{
    internal class Tester
    {
        public static void Main()
        {
            Duck duck = new MallardDuck();

            Turkey turkey = new WildTurkey();
            Duck turkeyAdapter = new TurkeyAdapter(turkey);

            turkeyAdapter.Quack();
            turkeyAdapter.Fly();
        }
    }
}
