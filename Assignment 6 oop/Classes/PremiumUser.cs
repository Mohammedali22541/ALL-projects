using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oop.Classes
{
    internal class PremiumUser : User
    {
       
        public override string? UserName { get; set; }
        public PremiumUser()
        {
            UserName = "PremiumUser";
        }

        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }
}
