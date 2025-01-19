using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04.Part_1
{
    internal class Manager:Employee
    {
        //b) Create a derived class named Manager that overrides the Work method to print "Manager is managing". 
        public override void Print()
        {
            Console.WriteLine("Manager is managing");
        }
    }
}
