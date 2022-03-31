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

        public bool Withdraw(Account account, double amount)
        {
            if (CheckAccountBalance(account, amount))
            {
                account.Balance -= amount;
                Console.WriteLine($"Din nye balance er: {account.Balance}kr.");
                return true;
            }
            else
            {
                Console.WriteLine("Kunne ikke trække beløbet fra.");
                return false;
            }

            throw new NotImplementedException();
        }

        public bool CheckAccountBalance(Account account, double withdrawAmount)
        {
            if (withdrawAmount < account.Balance && withdrawAmount > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Ikke nok penge på kontoen.");
                return false;
            }
            throw new NotImplementedException();
        }
    }
}
