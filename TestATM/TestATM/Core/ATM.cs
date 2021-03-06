﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestATM.Core
{
    public class ATM
    {

        public ATM(double cash)
        {

            Cash = cash;
            _cardProvider = new CardProvider();
        }


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

        private CreditCard CreditCard
        {

            get { return _creditCard; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"Credit card can't be null");
                }
                _creditCard = value;
            }
        }

        private bool IsPinCorrect { get; set; }

        public void InsertCard(string cardId)
        {

            if (CreditCard != null)
            {
                throw new ArgumentException("Card is already in ATM");
            }

            CreditCard = _cardProvider.GetCardById(cardId);

        }

        public void InsertMoney(double cash)
        {

            if (cash <= 0)
            {
                throw new ArgumentException("Cash must be positive number");
            }

            if (IsPinCorrect)
            {
                CreditCard.Cash += cash;
                Cash += cash;
            }

        }

        public void TakeMoney(double cash)
        {

            if (cash <= 0)
            {
                throw new ArgumentException("Cash must be positive number");
            }

            if (IsPinCorrect && (Cash > cash))
            {
                CreditCard.Cash -= cash;
                Cash -= cash;
            }

        }

        public void CheckPinCode(int pin)
        {
            if (_countOfIncorrectPin == 3)
            {
                BlockCreditCard();
            }
            else
            {
                if (CreditCard.Pin == pin)
                {
                    IsPinCorrect = true;
                }
                else
                {
                    _countOfIncorrectPin++;
                }
            }
        }

        public void GetBackCreditCard()
        {

            if (CreditCard != null)
            {

                CreditCard = null;
                _countOfIncorrectPin = 0;
            }

        }

        private void BlockCreditCard()
        {
            CreditCard.IsBlock = true;
            _cardProvider.UpdateCreditCard(CreditCard); 
        }

        private double _cash;
        private CreditCard _creditCard;
        private int _countOfIncorrectPin;
        private readonly CardProvider _cardProvider;

    }
}
