using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session05.Question_1.classes
{
    internal class Circle : IShape
    {

        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double Area
        {
            get { return radius * radius * Math.PI; }
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
