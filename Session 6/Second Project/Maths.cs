using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_6.Second_Project
{
    internal class Maths
    {
        #region Define Class Maths that has four methods: Add() Subtract() Multiply() Divide()

        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y) { return x - y; }
        public static int Multiply(int x, int y) { return x * y; }
        public static void Divide(int x, int y) {

            try
            {
                Console.WriteLine(x / y);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion
    }
}
