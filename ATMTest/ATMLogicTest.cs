using ATMBank.Entities;
using ATMBank.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ATMTest
{
    public class ATMLogicTest
    {
        private ATM _atmLogic = new ATM();

        [Theory]
        [InlineData(2244, 1666)]
        [InlineData(2244, 999999)]
        [InlineData(6666, -666)]
        public void CheckPin_ShouldFail(int userInput, int pin)
        {
            //Arrange
            bool expected = false;
            Card card = new Card(pin);

            //Act
            bool actual = _atmLogic.CheckPin(card, userInput);

            //Assert
            Assert.True(actual == expected);
        }

        [Theory]
        [InlineData(2244, 2244)]
        [InlineData(1666, 1666)]
        public void CheckPin_ShouldWork(int userInput, int pin)
        {
            //Arrange
            bool expected = true;
            Card card = new Card(pin);

            //Act
            bool actual = _atmLogic.CheckPin(card, userInput);

            //Assert
            Assert.True(expected == actual);
        }

        [Theory]
        [InlineData(14000.00)]
        [InlineData(-600.00)]
        public void Withdraw_ShouldFail(double withdrawAmount)
        {
            //Arrang
            Account account = new Account();
            bool expected = false;

            //Act
            bool actual = _atmLogic.Withdraw(account, withdrawAmount);


            //Assert
            Assert.True(actual == expected);
        }

        [Theory]
        [InlineData(1000.00)]
        [InlineData(600.00)]
        public void Withdraw_ShouldWork(double withdrawAmount)
        {
            //Arrang
            Account account = new Account();
            bool expected = true;

            //Act
            bool actual = _atmLogic.Withdraw(account, withdrawAmount);

            //Assert
            Assert.True(actual == expected);
        }

        [Theory]
        [InlineData(14000.00)]
        [InlineData(-600.00)]
        public void CheckBalance_ShouldFail(double withdrawAmount)
        {
            //Arrang
            Account account = new Account();
            bool expected = false;

            //Act
            bool actual = _atmLogic.CheckAccountBalance(account, withdrawAmount);

            //Assert
            Assert.True(actual == expected);
        }

        [Theory]
        [InlineData(1000.00)]
        [InlineData(600.00)]
        public void CheckBalance_ShouldWork(double withdrawAmount)
        {
            //Arrang
            Account account = new Account();
            bool expected = true;

            //Act
            bool actual = _atmLogic.Withdraw(account, withdrawAmount);

            //Assert
            Assert.True(actual == expected);
        }
    }
}
