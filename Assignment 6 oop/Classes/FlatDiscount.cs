using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oop.Classes
{
    internal class FlatDiscount : Discount
    {
        public decimal FlatAmount { get; set; }
        public override string? Name { get; set; }

        public FlatDiscount(decimal fixedAmount)
        {
            FlatAmount = fixedAmount;
            Name = "Flat Discount";
            
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return FlatAmount * decimal.Min(quantity , 1);
       }
    }
}
