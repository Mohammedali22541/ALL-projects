using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oop.Classes
{
    internal class BuyOneGetOneDiscount : Discount
    {
        public override string? Name { get; set; }
        public BuyOneGetOneDiscount()
        {

            Name = "BuyOneGetOneDiscount";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity < 2)
            {
                return 0;
            }
            return (price / 2) * (quantity / 2);

        }
    }
}
