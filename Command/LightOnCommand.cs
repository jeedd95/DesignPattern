namespace DesignPattern.Command
{
    internal class LightOnCommand : Command
    {
        private Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.On();
        }
    }
}
