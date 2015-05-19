namespace state
{
    public abstract class State
    {
        // Returns the amount for the current state
        public abstract int Amount
        {
            get;
        }

        public abstract void DepositNickel(VendingMachine vm);
        public abstract void DepositDime(VendingMachine vm);
        public abstract void DepositQuarter(VendingMachine vm);

        // Returns a nickel or a dime to the user depending on the state
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

        public override void DepositNickel(VendingMachine vm)
        {
            vm.ChangeState(Five.Instance);
        }

        public override void DepositDime(VendingMachine vm)
        {
            vm.ChangeState(Ten.Instance);
        }

        public override void DepositQuarter(VendingMachine vm)
        {
            vm.ChangeState(Zero.Instance);
            vm.Vend();
        }

        public override void ReturnChange(VendingMachine vm)
        {
            // Do nothing
        }
    }

    public class Five : State
    {
        private static object sync = new object();
        private static State instance;

        protected Five()
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
                            instance = new Five();
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
                return 5;
            }
        }

        public override void DepositNickel(VendingMachine vm)
        {
            vm.ChangeState(Ten.Instance);
        }

        public override void DepositDime(VendingMachine vm)
        {
            vm.ChangeState(Fifteen.Instance);
        }

        public override void DepositQuarter(VendingMachine vm)
        {
            vm.ChangeState(Instance);
            vm.Vend();
        }

        public override void ReturnChange(VendingMachine vm)
        {
            // Return a nickel and change state
            vm.ChangeState(Zero.Instance);
        }
    }

    public class Ten : State
    {
        private static object sync = new object();
        private static State instance;

        protected Ten()
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
                            instance = new Ten();
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
                return 10;
            }
        }

        public override void DepositNickel(VendingMachine vm)
        {
            vm.ChangeState(Fifteen.Instance);
        }

        public override void DepositDime(VendingMachine vm)
        {
            vm.ChangeState(Twenty.Instance);
        }

        public override void DepositQuarter(VendingMachine vm)
        {
            vm.ChangeState(Instance);
            vm.Vend();
        }

        public override void ReturnChange(VendingMachine vm)
        {
            // Return a dime and change state
            vm.ChangeState(Zero.Instance);
        }
    }

    public class Fifteen : State
    {
        private static object sync = new object();
        private static State instance;

        protected Fifteen()
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
                            instance = new Fifteen();
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
                return 15;
            }
        }

        public override void DepositNickel(VendingMachine vm)
        {
            vm.ChangeState(Twenty.Instance);
        }

        public override void DepositDime(VendingMachine vm)
        {
            vm.ChangeState(Zero.Instance);
            vm.Vend();
        }

        public override void DepositQuarter(VendingMachine vm)
        {
            vm.ChangeState(Instance);
            vm.Vend();
        }

        public override void ReturnChange(VendingMachine vm)
        {
            // Return a dime and change state
            vm.ChangeState(Five.Instance);
        }

    }

    public class Twenty : State
    {
        private static object sync = new object();
        private static State instance;

        protected Twenty()
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
                            instance = new Twenty();
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
                return 20;
            }
        }

        public override void DepositNickel(VendingMachine vm)
        {
            vm.ChangeState(Zero.Instance);
            vm.Vend();
        }

        public override void DepositDime(VendingMachine vm)
        {
            vm.ChangeState(Five.Instance);
            vm.Vend();
        }

        public override void DepositQuarter(VendingMachine vm)
        {
            vm.ChangeState(Instance);
            vm.Vend();
        }

        public override void ReturnChange(VendingMachine vm)
        {
            // Return a dime and change state
            vm.ChangeState(Ten.Instance);
        }
    }
}
