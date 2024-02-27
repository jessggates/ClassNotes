using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2
{
    internal class HourlyEmployee : Employee
    {
        public double HourlyWage { get; set; }
        public int HoursWorked { get; set; } //can initialize here =0; or inside the constructor

        public HourlyEmployee(string name, string systemID, double hourlyWage):base(name,systemID)
        {
            HourlyWage = hourlyWage;
            HoursWorked = 0;
        }

        public override double CalculatePay()
        {
            return HourlyWage * HoursWorked;
        }

        public override string GetInformation()
        {
            return $"{base.GetInformation()}, Hourly Wage: {HourlyWage}"; //majority of time you do straight override 
        }


    }
}
