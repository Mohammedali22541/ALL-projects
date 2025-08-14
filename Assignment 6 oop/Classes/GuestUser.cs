using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oop.Classes
{
    internal class GuestUser : User
    {
      
        public override string? UserName { get; set; }

        public GuestUser()
        {
            UserName = "GuestUser";
        }

        public override Discount GetDiscount()
        {
            return new NoDiscount(UserName);
        }
    }
}
