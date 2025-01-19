using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04.Part_1
{
    #region Part1 Q2
    ///    Q2) Create a class named Rectangle with the following constructors:
    ///●	A parameterless constructor that sets the width and height to 0.
    ///●	A constructor that accepts width and height as integers.
    ///●	A constructor that accepts a single integer and sets both width and height to that value

    internal class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Rectangle()
        {
        }
        public Rectangle(int value)
        {
            Width = value;
            Height = value;
        }
    } 
    #endregion


}
