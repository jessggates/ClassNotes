using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2
{
    internal class Person
    {

        public string Name { get; set; }

        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
        protected Person(string name) //constructor forces them to give you a name
        {
            Name = name;
        }



    }
}
