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
        [Fact]
        public void CheckPin_ShouldFail()
        {
            //Arrange
            int expected = 0666;
            int actual = 0660;

            bool status = false;

            //Act
            if (expected == actual)
            {
                status = true;
            }
            else if (expected != actual)
            {
                status = false;
            }

            //Assert
            Assert.False(status);
        }

        [Fact]
        public void CheckPin_ShouldWork()
        {
            //Arrange
            int expected = 0666;
            int actual = 0666;

            bool status = false;

            //Act
            if (expected == actual)
            {
                status = true;
            }
            else if (expected != actual)
            {
                status = false;
            }

            //Assert
            Assert.True(status);
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

            //False for withdraw available status (true is available)
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

            //False for withdraw available status (true is available)
            //Assert
            Assert.True(status);
        }
    }
}
