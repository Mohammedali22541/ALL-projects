using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oop.Classes
{
    internal class RegularUser : User
    {
        public override string? UserName  { get; set; }  

        public RegularUser() {
            UserName = "RegularUser";
        }
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
           

        }
    }
}
