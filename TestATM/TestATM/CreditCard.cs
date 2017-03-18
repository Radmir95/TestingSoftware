using System;

namespace TestATM
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

        private int Pin
        {
            get { return _pin; }
            set
            {

                int paramLength = value.ToString().Length;

                if (paramLength != 4)
                {
                    throw new ArgumentNullException($"Passed incorrect PIN length");

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
        private double Cash { get; set; }

        private DateTime ExpireDate
        {
            get { return _expireDate; }
            set { _expireDate = value; }
        }
        private int CV2
        {
            get { return _cv2; }
            set { _cv2 = value; }
        }
        private bool IsBlock
        {
            get { return _isBlock; }
            set { _isBlock = value; }
        }


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
        private DateTime _expireDate;
        private int _cv2;
        private bool _isBlock;


    }
}
