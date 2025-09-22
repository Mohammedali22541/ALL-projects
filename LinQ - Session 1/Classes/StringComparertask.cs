using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ___Session_1.Classes
{
    internal class StringComparertask : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            if (x is null || y is null) return false;
            return string.Concat(x.OrderBy(x => x)) == string.Concat(y.OrderBy(x => x));
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return string.Concat(obj.OrderBy(c=>c)).GetHashCode();
        }
    }
}
