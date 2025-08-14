using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oop.Classes
{
    internal abstract class User
    {
        public abstract string? UserName { get; set; }

        public abstract Discount GetDiscount();
    }
}
