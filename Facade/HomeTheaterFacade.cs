namespace DesignPattern.Facade
{
    internal class HomeTheaterFacade
    {
        private Amplifier amp;
        private Tuner tuner;
        private Screen screen;

        public HomeTheaterFacade(Amplifier amp, Tuner tuner, Screen screen)
        {
            this.amp = amp;
            this.tuner = tuner;
            this.screen = screen;
        }

        public void WatchMovie()
        {
            amp.On();
            tuner.On();
            screen.Down();
        }
    }
}
