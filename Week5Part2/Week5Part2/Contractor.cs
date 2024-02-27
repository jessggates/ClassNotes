using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2
{
    internal class Contractor : Employee
    {
        public double WeeklyFee { get; set; }

        public Contractor(string name, string systemID, double weeklyFee):base(name,systemID)
        {
            WeeklyFee = weeklyFee;
        }

        public override double CalculatePay()
        {
            return WeeklyFee;
        }

    }
}
