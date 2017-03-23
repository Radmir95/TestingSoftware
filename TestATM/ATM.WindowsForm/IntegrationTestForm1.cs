using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ATM.WindowsForm
{
    [TestClass()]
    public class IntegrationTestForm1
    {

        [TestMethod()]
        public void Form1_Form1ShouldBlockCreditCardAfter3IncorrectPin()
        {
            
            var form = new Form1();
            var t = typeof(Form1);

            var atmFieldInfo = t.GetField("atm", BindingFlags.Instance | BindingFlags.NonPublic);
            var atm = (TestATM.Core.ATM)atmFieldInfo.GetValue(form);

            atm.CheckPinCode(1111);
            atm.CheckPinCode(1111);
            atm.CheckPinCode(1111);
            atm.CheckPinCode(1111);

            Assert.IsTrue(atm.IsCardBlock());

        }

    }
}
