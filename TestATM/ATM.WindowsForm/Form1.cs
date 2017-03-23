using System;
using System.Windows.Forms;

namespace ATM.WindowsForm
{
    public partial class Form1 : Form
    {

        private TestATM.Core.ATM atm;

        public Form1()
        {

            InitializeComponent();

            atm = new TestATM.Core.ATM(40000);
            atm.InsertCard("43434");

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            var cardStatus = atm.IsCardBlock();

            if (cardStatus == true)
            {
                lblError.Text = "Card is blocked";

            }
            else
            {
                var text = tbPin.Text;
                var result = atm.CheckPinCode(Int32.Parse(text));

                lblError.Text = result == true ? "Succeed" : "Error";

            }

        }

    }
}
