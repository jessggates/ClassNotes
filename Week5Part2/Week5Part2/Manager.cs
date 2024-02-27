using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2
{
    internal class Manager : Employee
    {
        public long Salary { get; set; }

        public Manager(string name, string systemID, long salary) : base(name, systemID)
        {
            Salary = salary;
        }

        public override double CalculatePay()
        {
            return Salary / 52;
        }

    }
}
