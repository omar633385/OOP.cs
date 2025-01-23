using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session05.Question_1.classes
{
    internal class Rectangle : IRectangle
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get ; set ; }
        public double Height { get ; set ; }

        public double Area => Width* Height;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle Width:{Width}\nHeight:{Height}\nArea:{Area}");
        }
    }
}
