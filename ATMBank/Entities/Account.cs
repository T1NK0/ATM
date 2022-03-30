using System;

namespace ATMBank.Entities
{
    public class Account
    {
        #region fields
        private int _accountNumber;
        private double _balance;
        #endregion

        public Account()
        {
            _accountNumber = new Random().Next(100000, 999999);
            _balance = new Random().Next(002000, 999999);
        }

        #region properties
        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        #endregion
    }
}
