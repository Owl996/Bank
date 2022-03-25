using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;

namespace BankAccountTest_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr.Bryan Walton", beginningBalance);
            // Act and assert
            Assert.ThrowsException < System.ArgumentOutOfRangeException > (() => account.Debit(debitAmount));
        }
    }
}