using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oop.Classes
{
    internal class PercentageDiscount : Discount
    {
        public decimal Percentage {  get; set; }
        public override string? Name { get; set; }

        public PercentageDiscount(decimal percentage)
        {
            Percentage = percentage;
            Name = "PercentageDiscount";


        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (Percentage / 100) ;
        }
    }
}
