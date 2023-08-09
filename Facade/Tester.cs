namespace DesignPattern.Facade
{
    internal class Tester
    {
        public static void Main()
        {
            Amplifier amplifier = new Amplifier();
            Tuner tuner = new Tuner();
            Screen screen = new Screen();

            HomeTheaterFacade homeTheaterFacade = new HomeTheaterFacade(amplifier,tuner,screen);

            homeTheaterFacade.WatchMovie();
        }
    }
}
