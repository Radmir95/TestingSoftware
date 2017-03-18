using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestATM
{
    public class ATM
    {

        private double Cash
        {
            get { return _cash; } 
            set
            {

                if (value < 0)
                {
                    
                    throw new ArgumentNullException($"ATM cash can't be negative");

                }

            }
        }

        public void InsertCard()
        {
            



        }

        private double _cash;

    }
}
