using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2
{
    internal class Customer : Person
    {
        public string AccountNumber { get; set; }

        public Customer(string name, string accountNumber):base(name)
        {
            AccountNumber = accountNumber;
        }
    }
}
