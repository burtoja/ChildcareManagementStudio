using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetBalance method of the BalanceController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class BalanceControllerWhenGetBalance
    {
        [TestMethod]
        public void ShouldGetBalance()
        {
            //double expectedBalanceAmount = 1285;

            AccountHolder accountHolder = new AccountHolder()
            {
                AccountHolderId = 1
            };

            BalanceController balanceController = new BalanceController();

            Balance balance = balanceController.GetBalance(accountHolder);

            Assert.AreEqual(accountHolder.AccountHolderId, balance.AccountHolder.AccountHolderId);
            //Assert.AreEqual(expectedBalanceAmount, balance.Amount);
        }
    }
}