namespace DesignPattern.Command
{
    internal class LightOnCommand : Command
    {
        private Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }

        public void Undo()
        {
            light.Off();
        }
    }
}
