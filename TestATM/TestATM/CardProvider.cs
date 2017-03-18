using System;

namespace TestATM
{
    public class CardProvider
    {
        public CardProvider()
        {
        }

        public CreditCard GetCardById(string cardId)
        {
            switch (cardId)
            {

                case "12345678910":
                    return new CreditCard(cardId, 111, "Khusnutdinov Radmir", 30000 ,DateTime.Now.AddMonths(10), 222, false );
                case "23456789101":
                    return new CreditCard(cardId, 222, "Akhmetgailiev Ainur", 30000, DateTime.Now.AddMonths(10), 333, false);
                case "34567891012":
                    return new CreditCard(cardId, 333, "Nikitin Vitaliy", 30000, DateTime.Now.AddMonths(10), 444, true);
                default:
                    return new CreditCard(cardId, 444, "Zakharov Maxim", 30000, DateTime.Now.AddMonths(10), 555, false);

            }
        }

        public void UpdateCreditCard(CreditCard creditCard)
        {
            
            //Send new information on server

        }

    }
}