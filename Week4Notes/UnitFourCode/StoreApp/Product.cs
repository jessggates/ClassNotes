using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int CurrentQuantity { get; set; }



        public string DisplayProductDetails()
        {
            return $"Name: {Name}, Price: {Price}, Current Count: {CurrentQuantity}"; //could also do console writeline and public void but that's tightly coupling
        }

    }
}
