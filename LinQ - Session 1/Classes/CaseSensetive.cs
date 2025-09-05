using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ___Session_1.Classes
{
    internal class CaseSensetive : IComparer<string>
    {
       
        public int Compare(string? x, string? y)
        {
            return string.Compare(x, y , StringComparison.OrdinalIgnoreCase);
        }
    }
}
