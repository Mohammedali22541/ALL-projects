namespace Assignment_4_oop
{
    internal class Complex
    {
        #region Properties
        public int Real { get; set; }
        public int Imaginary { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Real} , {Imaginary}i";
        }


        #endregion

        #region Overloading
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Imaginary = (left?.Imaginary ?? 0) + (right?.Imaginary ?? 0)
            };

        }


        public static Complex operator -(Complex left, Complex right)
        {

            return new Complex
            {

                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imaginary = (left?.Imaginary ?? 0) - (right?.Imaginary ?? 0)

            };
        }

        public static Complex operator /(Complex left, Complex right)
        {

            return new Complex
            {

                Real = (left?.Real ?? 0) / (right?.Real ?? 0),
                Imaginary = (left?.Imaginary ?? 0) / (right?.Imaginary ?? 0)

            };
        }

        public static Complex operator ++(Complex c)
        {
            if (c is not null)
            {
                return new Complex()
                {
                    Real = (c?.Real ?? 0) + 1,
                    Imaginary = (c?.Imaginary ?? 0)
                };

            }
            else
            {
                return new Complex();
            }
        }

        public static Complex operator --(Complex c)
        {
            return new Complex()
            {

                Real = (c?.Real ?? 0) - 1,
                Imaginary = (c?.Imaginary ?? 0)

            };

        }

        #region طريقة استسهال :)
        ///public static bool operator > (Complex left, Complex right)
        ///{
        ///    return left?.Real?? 0 > right?.Real?? 0;
        ///}
        ///
        ///public static bool operator <(Complex left, Complex right)
        ///{
        ///    return left?.Real?? 0 < right?.Real ?? 0;
        ///} 
        #endregion

        public static bool operator >(Complex left, Complex right)
        {

            if (left?.Real == right?.Real)
            {
                return left?.Imaginary > right?.Imaginary;
            }
            else
            {
                return left?.Real > right?.Real;
            }
        }


        public static bool operator <(Complex left, Complex right)
        {
            if (left?.Real == right?.Real)
            {
                return left?.Imaginary < right?.Imaginary;
            }
            else
            {
                return left?.Real < right?.Real;
            }
        }



        public static explicit operator int (Complex c)
        {
            return c?.Real??0;
        }

        public static implicit operator string (Complex c)
        {
            //return $"{c.Real} , {c.Imaginary}";
            return c?.ToString() ?? string.Empty;
        }


        #endregion


    }
}
