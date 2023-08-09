namespace DesignPattern.Command
{
    internal class SimpleRemoteControl
    {
        Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void ButtonWasPressed()
        {
            command.Execute();
        }
    }
}
