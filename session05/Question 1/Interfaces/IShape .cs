using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session05.Question_1
{
    internal interface IShape
    {
        //Define an interface named IShape with a property Area and a method DisplayShapeInfo
        public double Area { get;}
        public void DisplayShapeInfo();
    }
}
