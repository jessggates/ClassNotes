using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitFourCode
{
    internal class Rectangle
    {
        // public string Color; //properties
        // public double Length; public variables are bad (do below instead)
        // public double Width;

        public string Color { get; set; } // this is an auto-property 
        public double Width { get; set; }
        public double Length { get; set; }


        /* spelling out fully is 
        private double length;
        public double Length
        {
            get {return length;}
            set {
                    if (value > 20)
                    {
                        length = 20;
                    }
                    else
                        {
                            length = value;
                    }
                }  -- can put business rules within the set, so it can't be set 
        }


        */




        private Guid idNumber; //hides the data so it can't be changed 

        public Rectangle(Guid idNumber, string color, double length, double width)
        {
            Color = color;
            Length = length;
            Width = width;
            this.idNumber = idNumber;
        } //this is the constructor class

        public Rectangle() : this(Guid.NewGuid(), "Black", 1.0, 1.0) // gives default values to empty 
        {

        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Rectangle Color: {Color}, Length: {Length}, Width: {Width}");
        } //this is the method 
    }
}
