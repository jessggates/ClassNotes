using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2
{
    internal class DisplayInfoClass
    {

        public void Show(int number)
        {

        }

        public void Show(string message)
        {
            Console.WriteLine("shows message");
        }

        public void Show(string message, int number)
        {
            Console.WriteLine("shows message with number");
        }

        public void Show(string message, int number, int secondNumber)
        {
            Console.WriteLine("shows message with two numbers");
        }

        // method overloading allows you to have exact same name
        //parameters must be diff types, different order, different number of parameters
    }
}
