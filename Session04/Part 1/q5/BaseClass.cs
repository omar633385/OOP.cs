using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04.Part_1.q5
{
    internal class BaseClass
    {
        //a) Create a base class BaseClass with a virtual method DisplayMessage
        //that prints  "Message from BaseClass".

        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass");
        }
    }
}
