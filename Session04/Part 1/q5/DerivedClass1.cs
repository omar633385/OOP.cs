using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04.Part_1.q5
{
    internal class DerivedClass1:BaseClass
    {
        //b) Create a derived class DerivedClass1 that overrides the DisplayMessage method using the override keyword.
        public override void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass1");
        }
    }
}
