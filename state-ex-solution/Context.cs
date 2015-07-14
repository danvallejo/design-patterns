using System;

namespace state_ex_solution
{
    public class VendingMachine
    {
        private State state = Zero.Instance;
        private int change;

        public int CurrentChange
        {
            get
            {
                return change;
            }
        }

        public State CurrentState
        {
            get
            {
                return state;
            }
        }

        public int ProductAmount
        {
            get;
            set;
        }

        public void ChangeState(State to)
        {
            state = to;
        }

        public void DepositQuarter()
        {
            state.DepositQuarter(this);
        }

        public void Vend()
        {
            Console.WriteLine("Vending...");
            change = ReturnChange();
        }

        public int ReturnChange()
        {
            int amount = state.Amount;

            if (amount > 0)
            {
                Console.WriteLine("Returning {0}...", amount);
            }

            while (state != Zero.Instance)
            {
                state.ReturnChange(this);
            }

            return amount;
        }
    }
}
