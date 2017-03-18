using System;

namespace TestATM.Core
{
    public class CreditCard
    {
        private string CardID
        {
            get
            {
                if (_cardId == null)
                {

                    throw new ArgumentNullException($"CardID is null");

                }

                return _cardId;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"Passed null argument in CardID");
                }
                _cardId = value;
            }
        }

        public int Pin
        {
            get { return _pin; }
            set
            {

                int paramLength = value.ToString().Length;

                if (paramLength != 4)
                {
                    throw new ArgumentException($"Passed incorrect PIN length");

                }
                _pin = value;
            }
        }
        private string User
        {
            get
            {
                if (_user == null)
                {

                    throw new ArgumentNullException($"User is null");

                }
                return _user;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"Passed null argument in User");

                }
                _user = value;
            }
        }
        public double Cash { get; set; }

        private DateTime ExpireDate { get; set; }

        private int CV2 { get; set; }

        public bool IsBlock { get; set; }


        public CreditCard(string cardID, int pin, string user, double cash, DateTime expireDate, int cv2, bool isBlock)
        {

            CardID = cardID;
            Pin = pin;
            User = user;
            Cash = cash;
            ExpireDate = expireDate;
            CV2 = cv2;
            IsBlock = isBlock;

        }

        private string _cardId;
        private int _pin;
        private string _user;
    }
}
