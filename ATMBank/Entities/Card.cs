using System;

namespace ATMBank.Entities
{
    public class Card
    {
        #region fields
        private int _cardNumber;
        private Account _account;
        private int _pinCode;
        #endregion

        public Card(Account account)
        {
            _account = account;
            _pinCode = 0666;
            _cardNumber = new Random().Next(10000000, 99999999);
        }

        #region properties
        public int CardNumber
        {
            get { return _cardNumber; }
            set { _cardNumber = value; }
        }

        public Account Account
        {
            get { return _account; }
            set { _account = value; }
        }
        public int PinCode
        {
            get { return _pinCode; }
            set { _pinCode = value; }
        }
        #endregion
    }
}
