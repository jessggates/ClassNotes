using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Notes
{
    internal class Car
    {
        private int speed;

        public string Color { get; set; }

        public string Accelerate()
        {
            speed += 10;
            return "The car is accelerating";
        }
    }
}
