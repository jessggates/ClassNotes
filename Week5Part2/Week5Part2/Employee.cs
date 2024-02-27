using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2
{
    internal class Employee : Person
    {

        public string SystemID { get; set; }

        protected Employee(string name , string systemID):base(name) 
        {
            SystemID = systemID;
        }

        public virtual double CalculatePay()
        {
            return 0;
        }

        public virtual string GetInformation()
        {
            return $"Name: {Name}, SystemID: {SystemID},  ";
        }

    }
}
