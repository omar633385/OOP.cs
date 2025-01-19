using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04.Part_1
{
    internal class Employee
    {
    ///    a) Create a base class named Employee with method That Work as it prints    "Employee is  working".
    ///b) Create a derived class named Manager that overrides the Work method to print "Manager is managing". 
    ///*Ensure that the Manager class also calls the Work method of the Employee class within its Overridden method.
    ///
    public virtual void Print()
        {
            Console.WriteLine("Employee is  working");
        }

    }
}
