using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestATM.Core;

namespace TestATM.IntegrationTest
{
    [TestClass()]
    public class IntegrationTestATM
    {

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ATM_ShouldThrowArgumenException_ThenPassNegativeArgumentCash()
        {
            var atm = new ATM(-100000);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ATM_ShouldThrowArgumenNullException_ThenPassNullArgumentCreditCardID()
        {
            var atm = new ATM(100000);
            atm.InsertCard(null);
        }

        [TestMethod]
        public void ATM_CreditCardShouldBlocked_ThenPinWillBeIncorect3Times()
        {
            var atm = new ATM(10000);
            atm.InsertCard("12345678910");

            atm.CheckPinCode(6666);
            atm.CheckPinCode(6666);
            atm.CheckPinCode(6666);

            var t = typeof(ATM);
            var creditCardPropertyInfo = t.GetProperty("CreditCard", BindingFlags.Instance | BindingFlags.NonPublic);
            var creditCard = (CreditCard)creditCardPropertyInfo.GetValue(atm);

            Assert.IsFalse(creditCard.IsBlock);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ATM_ShouldThrowArgumentException_ThenCashArgumentNegative()
        {
            var atm = new ATM(10000);
            atm.TakeMoney(-300);

        }


    }
}
