namespace DesignPattern.State
{
    internal interface State
    {
        void InsertQuarter();
        void ejectQuarter();
        void TurnCrank();
        void Dispense();
    }
}
