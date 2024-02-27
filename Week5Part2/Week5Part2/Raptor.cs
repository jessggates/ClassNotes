using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2
{
    internal class Raptor : Bird   
    {
        public string FavoritePrey { get; set; }
    }

    public override string Speak()
    {
        return "arrrrr";
    }
}
