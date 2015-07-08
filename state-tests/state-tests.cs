using Microsoft.VisualStudio.TestTools.UnitTesting;
using state;

namespace state_tests
{
    [TestClass]
    public class StateTestFixture
    {
        [TestMethod]
        public void TestEmptyVend()
        {
            VendingMachine vend = new VendingMachine();
            Assert.AreEqual(Zero.Instance, vend.CurrentState);
        }
        [TestMethod]
        public void TestDeposit05()
        {
            VendingMachine vend = new VendingMachine();
            vend.DepositNickel();
            Assert.AreEqual(Five.Instance, vend.CurrentState);
        }
        [TestMethod]
        public void TestDeposit10()
        {
            VendingMachine vend = new VendingMachine();
            vend.DepositDime();
            Assert.AreEqual(Ten.Instance, vend.CurrentState);
        }
        [TestMethod]
        public void TestDeposit25()
        {
            VendingMachine vend = new VendingMachine();
            vend.DepositQuarter();
            Assert.AreEqual(Zero.Instance, vend.CurrentState);
            Assert.AreEqual(0, vend.CurrentChange);
        }
        [TestMethod]
        public void TestDeposit30()
        {
            VendingMachine vend = new VendingMachine();
            vend.DepositDime();
            vend.DepositDime();
            Assert.AreEqual(Twenty.Instance, vend.CurrentState);
            vend.DepositDime();
            Assert.AreEqual(Zero.Instance, vend.CurrentState);
            Assert.AreEqual(5, vend.CurrentChange);
        }
        [TestMethod]
        public void TestDeposit35()
        {
            VendingMachine vend = new VendingMachine();
            vend.DepositDime();
            vend.DepositQuarter();
            Assert.AreEqual(Zero.Instance, vend.CurrentState);
            Assert.AreEqual(10, vend.CurrentChange);
        }
        [TestMethod]
        public void TestDeposit40()
        {
            VendingMachine vend = new VendingMachine();
            vend.DepositNickel();
            vend.DepositDime();
            vend.DepositQuarter();
            Assert.AreEqual(Zero.Instance, vend.CurrentState);
            Assert.AreEqual(15, vend.CurrentChange);
        }
        [TestMethod]
        public void TestDeposit45()
        {
            VendingMachine vend = new VendingMachine();
            vend.DepositDime();
            vend.DepositDime();
            vend.DepositQuarter();
            Assert.AreEqual(Zero.Instance, vend.CurrentState);
            Assert.AreEqual(20, vend.CurrentChange);
        }
    }
}
