using System;

namespace DesignPattern.State
{
    internal class GumballMachine
    {
        private State soldOutState;
        private State soldState;

        private State state;
        private int count = 0;

        public void SetState(int numberGumballs)
        {
            soldState = new SoldState(this);
            soldOutState = new SoldOutState(this);

            this.count = numberGumballs;
            state = soldState;
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        public State GetHasQuarterState()
        {
            throw new NotImplementedException();
        }
    }
}