using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_6.ThirdProject
{
    internal abstract class Discount
    {
        public string Name { get; set; }
        public abstract double CalculateDiscount(decimal price, int quantity);

    }
}
