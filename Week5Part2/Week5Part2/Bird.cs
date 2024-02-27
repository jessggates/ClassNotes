using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2
{
    internal class Bird : Animal //bird is the derived class, animals is the base class (parent/child)
    {

        public int WingSpan { get; set; }

        public void Fly() { }

        public Bird() { }

        public Bird(string name)
        {
            Name = name;
        }

        public Bird(int wingSpan, string name)
        {
            WingSpan = wingSpan;
            Name = name;
        }

        public override string Speak()
        {
            return "tweet tweet";
        }

    }
}
