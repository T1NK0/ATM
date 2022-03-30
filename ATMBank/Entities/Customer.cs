using System;
using System.Collections.Generic;

namespace ATMBank.Entities
{
    public class Customer
    {
        #region fields
        private string _firstName;
        private string _lastName;
        private List<Account> _accounts;
        private List<Card> _cards;
        //Guid makes a unique number that can almost never be the same.
        private Guid _customerNumber;
        #endregion

        #region Constructor
        public Customer(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _accounts = new List<Account>();
            _cards = new List<Card>();
            _customerNumber = Guid.NewGuid();
        }
        #endregion

        #region methods
        //Adds account to accounts list.
        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }

        //Adds card to card list
        public void AddCard(Card card)
        {
            Cards.Add(card);
        }
        #endregion

        #region properties
        public string FirstName
        {
            get { return _firstName; }
            private set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            private set { _lastName = value; }
        }
        public List<Account> Accounts
        {
            get { return _accounts; }
            private set { _accounts = value; }
        }

        public List<Card> Cards
        {
            get { return _cards; }
            private set { _cards = value; }
        }

        public Guid CustomerNumber
        {
            get { return _customerNumber; }
            private set { _customerNumber = value; }
        }
        #endregion
    }
}
