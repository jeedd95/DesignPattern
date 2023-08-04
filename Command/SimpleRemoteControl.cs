namespace DesignPattern.Command
{
    internal class SimpleRemoteControl
    {
        Command slot;

        public void SetCommand(Command command)
        {
            slot = command;
        }

        public void ButtonWasPressed()
        {
            slot.execute();
        }
    }
}
