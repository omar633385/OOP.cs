using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session04.Part_1
{
    internal class Complex
    {


        #region Part 1 Q3
        ///   Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
        ///* Note: Overload the +, - operator to add and subtract two complex numbers.

        #region Properties
        public int Real { get; set; }
        public int Imaginary { get; set; }

        #endregion

        #region Constructors

        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public Complex()
        {

        }
        #endregion

        #region Methods

        #region Operators Overloading
        public static Complex operator +(Complex a, Complex b)
        {
            Complex c = new Complex();

            c.Real = (a?.Real ?? 0) + (b?.Real ?? 0);
            c.Imaginary = (a?.Imaginary ?? 0) + (b?.Imaginary ?? 0);
            return c;
        }
        public static Complex operator -(Complex a, Complex b)
        {
            Complex c = new Complex();

            c.Real = (a?.Real ?? 0) - (b?.Real ?? 0);
            c.Imaginary = (a?.Imaginary ?? 0) - (b?.Imaginary ?? 0);
            return c;
        }
        #endregion

        public override string ToString()
        {
            return $"{Real}+{Imaginary}i";
        }
        #endregion

        #endregion


    }
}
