using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session05.Question_1.classes
{
    internal class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area
        {
            get { return Radius * Radius * Math.PI; }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle radius={Radius}\nArea={Area}");
        }
    }
}
