using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Notes
{
    internal class Account
    {
        private decimal balance;

        public Account(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                throw new ArgumentException("Insufficient balance or invalid deposit amount");
            }
        }

        public void Withdrawal(decimal amount)
        {
            if (amount > 0)
            {
                balance -= amount;
            }
            else
            {
                throw new ArgumentException("Insufficient balance of invalid withdrawal amount");
            }

        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}

//do not put a try catch in your own class 