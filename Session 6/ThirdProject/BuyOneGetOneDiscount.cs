using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_6.ThirdProject
{
    internal class BuyOneGetOneDiscount : Discount
    {
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity>1)
            {
                return (price / 2)*(quantity / 2);
            }
            else
                return price*quantity;
        }
    }
}
