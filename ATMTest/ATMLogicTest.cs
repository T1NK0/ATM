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
        public void CheckPin_ShouldFail(int userPress, int pin)
        {
            //Arrange
            bool expected = false;
            Card card = new Card(pin);

            //Act
            bool actual = _atmLogic.CheckPin(card, userPress);

            //Assert
            Assert.True(actual == expected);
        }

        [Theory]
        [InlineData(2244, 2244)]
        [InlineData(1666, 1666)]
        public void CheckPin_ShouldWork(int userPress, int pin)
        {
            //Arrange
            bool expected = true;
            Card card = new Card(pin);

            //Act
            bool actual = _atmLogic.CheckPin(card, userPress);

            //Assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void Withdraw_ShouldFail()
        {
            //Arrange
            double accountBalance = 2500.00;
            double withdrawAmount = 2600.00;

            //Act
            accountBalance -= withdrawAmount;

            //Assert
            Assert.False(accountBalance > 0);
        }

        [Fact]
        public void Withdraw_ShouldWork()
        {
            //Arrange
            double accountBalance = 2500.00;
            double withdrawAmount = 250.00;

            //Act
            if (accountBalance > withdrawAmount)
            {
                accountBalance -= withdrawAmount;
            }

            //Assert
            Assert.True(accountBalance > 0);
        }

        [Fact]
        public void CheckBalance_ShouldFail()
        {
            //Arrange
            double balance = 2500.00;
            double withdraw = 2600.00;

            bool status = false;

            //Act
            if (balance > withdraw)
            {
                status = true;
            } 
            else if (balance < withdraw)
            {
                status = false;
            }

            //Assert
            Assert.False(status);
        }

        [Fact]
        public void CheckBalance_ShouldWork()
        {
            //Arrange
            double balance = 2500.00;
            double withdraw = 600.00;

            bool status = false;

            //Act
            if (balance > withdraw)
            {
                status = true;
            }
            else if (balance < withdraw)
            {
                status = false;
            }
                
            //Assert
            Assert.True(status);
        }
    }
}
