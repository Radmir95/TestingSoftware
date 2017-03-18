using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestATM.Core;

namespace TestATM.IntegrationTest
{

    [TestClass()]
    public class IntegrationTestCreditCard
    {

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreditCard_ShouldThrowArgumentNullException_ThenPassNullArgumentCardID()
        {
            var card = new CreditCard(null, 1111, "Khusnutdinov Radmir", 100000, DateTime.Now, 222, false);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CreditCard_ShouldThrowArgumentException_ThenPassIncorrectPin()
        {
            var card = new CreditCard("43434343", 111, "Khusnutdinov Radmir", 100000, DateTime.Now, 222, false);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreditCard_ShouldThrowArgumentNullException_ThenPassNullArgumentUser()
        {
            var card = new CreditCard("3434343434", 1111, null, 100000, DateTime.Now, 222, false);
        }

    }
}
