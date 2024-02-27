using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2
{
    internal class Fish : Animal
    {

        public string GillType { get; set; }

        public void Swim() { }

        public override string Speak()
        {
            return "glub glub";
        }

    }
}
