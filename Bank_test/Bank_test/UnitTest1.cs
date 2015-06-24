using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank_test
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            Komp_Test.BankAccount account = new Komp_Test.BankAccount("Mr. Bryan Walton", beginningBalance);

            // act
            account.Debit(debitAmount);

            // assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
        [TestMethod]
        public void Credit_WithValidAmount_UpdatesBalance() {
            // arrange
            double beginningBalance = 11.99;
            double creditAmount = 4.55;
            double expected = 16.54;
            Komp_Test.BankAccount account = new Komp_Test.BankAccount("Mr. Bryan Walton", beginningBalance);

            // act
            account.Credit(creditAmount);

            // assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not credited correctly");
        }
    }
}
