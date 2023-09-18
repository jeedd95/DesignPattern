namespace DesignPattern.State
{
    internal class SoldState : State
    {
        private GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            throw new System.NotImplementedException();
        }

        public void ejectQuarter()
        {
            throw new System.NotImplementedException();
        }

        public void InsertQuarter()
        {
            gumballMachine.SetState(gumballMachine.GetHasQuarterState());
        }

        public void TurnCrank()
        {
            throw new System.NotImplementedException();
        }
    }
}
