using ATMBank.Entities;
using System;

namespace ATMBank.Logic
{
    public class ATM
    {
        public bool CheckPin(Card card, int input)
        {
            if (card != null)
            {
                return card.PinCode.Equals(input);
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public void Withdraw(Account account, double amount)
        {
            if (CheckAccountBalance(account, amount) == true)
            {
                account.Balance -= amount;
            }

            throw new NotImplementedException();
        }

        public bool CheckAccountBalance(Account account, double withdrawAmount)
        {
            if (withdrawAmount < account.Balance)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }
    }
}
