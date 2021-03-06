﻿using System;

namespace state
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

        public void ChangeState(State to)
        {
            state = to;
        }

        public void DepositNickel()
        {
            state.DepositNickel(this);
        }

        public void DepositDime()
        {
            state.DepositDime(this);
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

            Console.WriteLine("Returning {0}...", amount);

            while (state != Zero.Instance)
            {
                state.ReturnChange(this);
            }

            return amount;
        }
    }
}
