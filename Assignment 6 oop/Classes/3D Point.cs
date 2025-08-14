using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oop.Classes
{
    internal class _3D_Point : IComparable<_3D_Point> , ICloneable
    {

        #region Properties
        public int D1 { get; set; }
        public int D2 { get; set; }
        public int D3 { get; set; }

        #endregion

        #region Constructrs

        public _3D_Point()
        {
            
        }
        public _3D_Point(int d1, int d2, int d3)
        {
            D1 = d1;
            D2 = d2;
            D3 = d3;


        }

        public _3D_Point(int d1, int d2)
        {
            D1 = d1;
            D2 = d2;

        }
        #endregion

        #region Methods



        public static bool operator == (_3D_Point a, _3D_Point b)
        {
            if (a is  null && b is null)
            {
                return true;
            }
            if (a is null || b is null)
            {
                return false;
            }

            return a.D1 == b.D1 && a.D2 == b.D2;
        }

        public static bool operator != (_3D_Point a, _3D_Point b)
        {
            return !(a == b);

        }

        //public override string ToString()
        //{
        //    return $"Point Coordinates: ({D1} , {D2} , {D3})";
        //}

        public override string ToString()
        {
            return $"({D1}, {D2})";
        }




        public int CompareTo(_3D_Point? other)
        {
            if (this.D1 == other.D1)
            {
                if (this.D2 > other.D2)
                {
                    return 1;
                }
                else if(this.D2 < other.D2)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else if (this.D1 > other?.D1)
            {   
                return 1;
                
            }
            else
            {
                return -1;
            }
        }

        public object Clone()
        {
            return new _3D_Point()
            {
                  D1 = this.D1,
                  D2 = this.D2,
            };
        }



        #endregion

    }
}
