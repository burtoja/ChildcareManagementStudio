using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetAllBalances method of the BalanceController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class BalanceControllerWhenGetAllBalances
    {
        [TestMethod]
        public void ShouldReturnAllBalances()
        {
            BalanceController balanceController = new BalanceController();
            List<Balance> balances = balanceController.GetAllBalances();

            Assert.AreEqual(3, balances.Count);
        }
    }
}