namespace DesignPattern.Command
{
    internal interface Command
    {
        void Execute();

        void Undo();
    }
}
