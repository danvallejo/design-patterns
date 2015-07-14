using System;

namespace state_ex_solution
{
    public abstract class State
    {
        // Returns the amount for the current state
        public abstract int Amount
        {
            get;
        }

        public abstract void DepositQuarter(VendingMachine vm);
        
        public abstract void ReturnChange(VendingMachine vm);
    }

    public class Zero : State
    {
        private static object sync = new object();
        private static State instance;

        protected Zero()
        {
        }

        public static State Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (sync)
                    {
                        if (instance == null)
                        {
                            instance = new Zero();
                        }
                    }
                }

                return instance;
            }
        }

        public override int Amount
        {
            get
            {
                return 0;
            }
        }

        public override void DepositQuarter(VendingMachine vm)
        {
            vm.ChangeState(TwentyFive.Instance);

            if (vm.ProductAmount == vm.CurrentState.Amount)
            {
                vm.ChangeState(Zero.Instance);
                vm.Vend();
            }
        }

        public override void ReturnChange(VendingMachine vm)
        {
            // Do nothing
        }
    }

    public class TwentyFive : State
    {
        private static object sync = new object();
        private static State instance;

        protected TwentyFive()
        {
        }

        public static State Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (sync)
                    {
                        if (instance == null)
                        {
                            instance = new TwentyFive();
                        }
                    }
                }

                return instance;

            }
        }

        public override int Amount
        {
            get
            {
                return 25;
            }
        }

        public override void DepositQuarter(VendingMachine vm)
        {
            vm.ChangeState(Fifty.Instance);

            if (vm.ProductAmount == vm.CurrentState.Amount)
            {
                vm.ChangeState(Zero.Instance);
                vm.Vend();
            }
        }

        public override void ReturnChange(VendingMachine vm)
        {
            Console.WriteLine("Returning {0}", Amount);
            vm.ChangeState(Zero.Instance);
        }
    }

    public class Fifty : State
    {
        private static object sync = new object();
        private static State instance;

        protected Fifty()
        {
        }

        public static State Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (sync)
                    {
                        if (instance == null)
                        {
                            instance = new Fifty();
                        }
                    }
                }

                return instance;

            }
        }

        public override int Amount
        {
            get
            {
                return 50;
            }
        }

        public override void DepositQuarter(VendingMachine vm)
        {
            vm.ChangeState(SeventyFive.Instance);

            if (vm.ProductAmount == vm.CurrentState.Amount)
            {
                vm.ChangeState(Zero.Instance);
                vm.Vend();
            }
        }

        public override void ReturnChange(VendingMachine vm)
        {
            Console.WriteLine("Returning {0}", Amount);
            vm.ChangeState(Zero.Instance);
        }
    }

    public class SeventyFive : State
    {
        private static object sync = new object();
        private static State instance;

        protected SeventyFive()
        {
        }

        public static State Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (sync)
                    {
                        if (instance == null)
                        {
                            instance = new SeventyFive();
                        }
                    }
                }

                return instance;

            }
        }

        public override int Amount
        {
            get
            {
                return 75;
            }
        }

        public override void DepositQuarter(VendingMachine vm)
        {
            vm.ChangeState(Zero.Instance);
            vm.Vend();
        }

        public override void ReturnChange(VendingMachine vm)
        {
            Console.WriteLine("Returning {0}", Amount);
            vm.ChangeState(Zero.Instance);
        }
    }
}
