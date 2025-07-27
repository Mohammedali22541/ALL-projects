using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_oop
{
    [Flags]
    internal enum Permissions : byte
    {   
        read = 1,
        write = 2,
        delete = 4,
        execute = 8,
    }
}
