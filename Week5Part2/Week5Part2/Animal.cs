using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2
{
    public class Animal
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        // protected Animal() { } only use this if it will be inherited by another class, otherwise no one can create a new animal 

        public void Eat() { }

        public void Sleep() { }

        public virtual string Speak() //this turns it into a override method
        {
            return "i'm an animal, rrrrr";
        }

    }
}
