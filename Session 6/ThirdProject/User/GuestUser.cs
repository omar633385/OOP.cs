using Session_6.ThirdProject.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_6.ThirdProject.User
{
    internal class GuestUser : User
    {
        public override Discount GetDiscount()
        {
            return new FlatDiscount(0);
        }
    }
}
