using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04.Part_1.q5
{
    internal class DerivedClass2:BaseClass
    {
        public new void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass2");
        }
    }
}
