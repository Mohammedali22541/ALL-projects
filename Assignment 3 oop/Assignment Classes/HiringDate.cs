using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_oop.Assignment_Classes
{
    internal class HiringDate
    {
        #region Attributes
        private int years;
        private int months;
        private int days;
        #endregion

        #region Constructors
        public HiringDate(int years, int months, int days)
        {
            this.years = years;
            this.months = months;
            this.days = days;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return  $"{years}/{months}/{days}";
        }
        #endregion
    }
}
