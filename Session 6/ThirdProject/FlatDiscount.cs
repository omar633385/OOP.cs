using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_6.ThirdProject
{
    internal class FlatDiscount : Discount
    {
        

        public int DeductedAmount { get; set; }
        public FlatDiscount(int amount)
        {
            DeductedAmount = amount;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return DeductedAmount * Math.Min(quantity, 1);
        }
    }
}
