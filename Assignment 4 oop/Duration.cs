using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_oop
{
    internal class Duration
    {

        #region Properties

        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Second { get; set; }
        #endregion

        #region Method 
        public override string ToString()
        {
            return $"Hours: {Hours} ,Minutes: {Minutes} ,Seconds: {Second} ";
        }

        #endregion

        #region Constructors

        public Duration()
        {

        }

        public Duration(int hours, int minutes, int second)
        {
            Hours = hours;
            Minutes = minutes;
            Second = second;
        }

        public Duration(int value)
        {

            #region الطريقة اللي فكرت فيها قبل ماابحث عن حاجة افضل
            ///int result = value / 60;
            ///
            ///if (result % 60 == 0)
            ///{
            ///
            ///    Hours = result /60;
            ///
            ///}
            ///else if (result > 60 )
            ///{
            ///    Hours = result / 60;
            ///    Minutes = result % 60;
            ///} else if (result < 60)
            ///{
            ///    Minutes = result;
            ///    Second = value % 60;
            ///} 
            #endregion

            #region الطريقة الصح اني اقسم علي  عدد الثواني علطول وهي الاسهل من القسمة الدقايق الاول

            Hours = value / 3600;
            int remainingValue = value % 3600;
            Minutes = remainingValue / 60;
            Second = remainingValue % 60;
        }

        #endregion
        #endregion

        #region Overloading

        #region +
        public static Duration operator +(Duration left, Duration right)
        {
            int totalHours = left.Hours + right.Hours;
            int totalMinutes = left.Minutes + right.Minutes;
            int totalSecond = left.Second + right.Second;


            if (totalMinutes >= 60)
            {
                totalHours += totalMinutes / 60;
                totalMinutes += totalMinutes % 60;

            }
            if (totalSecond >= 60)
            {
                totalMinutes += totalSecond / 60;
                totalSecond = totalSecond % 60;
            }



            return new Duration
            {
                Hours = totalHours,
                Minutes = totalMinutes,
                Second = totalSecond
            };
        }











        public static Duration operator +(Duration left, int num)
        {

            Duration right;
            right = new Duration(num);

            int totalHours = left.Hours + right.Hours;
            int totalMinutes = left.Minutes + right.Minutes;
            int totalSecond = left.Second + right.Second;


            if (totalMinutes >= 60)
            {
                totalHours += totalMinutes / 60;
                totalMinutes += totalMinutes % 60;

            }
            if (totalSecond >= 60)
            {
                totalMinutes += totalSecond / 60;
                totalSecond = totalSecond % 60;
            }



            return new Duration
            {
                Hours = totalHours,
                Minutes = totalMinutes,
                Second = totalSecond
            };
        }




        public static Duration operator +(int num, Duration right)
        {

            Duration left;
            left = new Duration(num);

            int totalHours = left.Hours + right.Hours;
            int totalMinutes = left.Minutes + right.Minutes;
            int totalSecond = left.Second + right.Second;


            if (totalMinutes >= 60)
            {
                totalHours += totalMinutes / 60;
                totalMinutes += totalMinutes % 60;

            }
            if (totalSecond >= 60)
            {
                totalMinutes += totalSecond / 60;
                totalSecond = totalSecond % 60;
            }



            return new Duration
            {
                Hours = totalHours,
                Minutes = totalMinutes,
                Second = totalSecond
            };
        }





        #endregion

        #region -

        public static Duration operator -(Duration left, Duration right)
        {
            int totalHours = left.Hours - right.Hours;
            int totalMinutes = left.Minutes - right.Minutes;
            int totalSecond = left.Second - right.Second;

            if (totalSecond < 0)
            {
                if (totalMinutes <= 0)
                {
                    totalSecond = 0;
                }
                else
                {
                    //int remain = totalSecond;

                    totalSecond += 60;
                    totalMinutes = totalMinutes - 1;

                    //totalSecond += remain;

                }
            }

            if (totalMinutes < 0)
            {
                if (totalHours <= 0)
                {
                    totalMinutes = 0;
                }
                else
                {
                    //int remain = totalMinutes;
                    totalMinutes += 60;
                    totalHours -= 1;

                    //totalMinutes += remain;

                }
            }



            return new Duration
            {
                Hours = totalHours,
                Minutes = totalMinutes,
                Second = totalSecond
            };
        }
        #endregion

        #region ++
        public static Duration operator ++(Duration d)
        {
            return new Duration

            {
                Hours = (d?.Hours ?? 0),
                Minutes = (d?.Minutes ?? 0) + 1,
                Second = (d?.Second ?? 0)


            };
        }



        #endregion

        #region --
        public static Duration operator --(Duration d)
        {
            return new Duration

            {
                Hours = (d?.Hours ?? 0),
                Minutes = (d?.Minutes ?? 0) - 1,
                Second = (d?.Second ?? 0)


            };
        }
        #endregion

        #region >
        public static bool operator >(Duration left, Duration right)
        {
            if (left.Hours == right.Hours)
            {
                if (left.Minutes == right.Minutes)
                {
                    return left.Second > right.Second;
                }
                else
                {
                    return left.Minutes > right.Minutes;
                }
            }
            else
            {
                return left.Hours > right.Hours;
            }
        }




        #endregion

        #region <

        public static bool operator <(Duration left, Duration right)
        {
            if (left.Hours == right.Hours)
            {
                if (left.Minutes == right.Minutes)
                {
                    return left.Second < right.Second;
                }
                else
                {
                    return left.Minutes < right.Minutes;
                }
            }
            else
            {
                return left.Hours < right.Hours;
            }
        }

        #endregion

        #region >=
        public static bool operator >=(Duration left, Duration right)
        {
            return !(left < right);

        }
        #endregion

        #region <=
        public static bool operator <=(Duration left, Duration right)
        {
            return !(left > right);

        }
        #endregion

        #region True
        public static bool operator true(Duration d)
        {

            return d.Hours > 0 || d.Minutes > 0 || d.Second > 0;

        }

        #endregion

        #region false
        public static bool operator false(Duration d)
        {

            return !(d.Hours > 0 || d.Minutes > 0 || d.Second > 0);


        } 
        #endregion

        public static explicit operator DateTime(Duration d)
        {
            return DateTime.Today .AddHours(d.Hours) .AddMinutes(d.Minutes) .AddSeconds(d.Second);
        }
        #endregion
    }
}




