using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_6.ThirdProject.Discounts
{
    internal class PercentageDiscount : Discount
    {


        public int Percentage { get; set; }
        public PercentageDiscount(int percentage)
        {
            Percentage = percentage;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (Percentage / 100);
        }
    }
}
