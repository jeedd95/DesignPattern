namespace DesignPattern.State
{
    internal class SoldOutState : State
    {
        private GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
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
            throw new System.NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new System.NotImplementedException();
        }
    }
}
