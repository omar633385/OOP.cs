using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Session04.Part_2
{
    internal class Duration
    {


        //1-Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
        #region Properties
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region Constructors
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int seconds)
        {
            Hours = seconds / 3600;
            Minutes = (seconds % 3600) / 60;
            Seconds = seconds % 60;
        }
        public Duration()
        {

        }
        #endregion

        #region 2-Override All System. Object Members [To String(), Equals(),GetHashCode() ] .
        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
        }
        public override bool Equals(object? obj)
        {
            return this.Equals(obj as Duration);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region OperatorOverloading
        public static Duration operator +(Duration a, Duration b)
        {
            Duration c = new Duration();
            c.Hours = (a?.Hours ?? 0) + (b?.Hours ?? 0);
            c.Minutes = (a?.Minutes ?? 0) + (b?.Minutes ?? 0);
            c.Seconds = (a?.Seconds ?? 0) + (b?.Seconds ?? 0);
            return c;
        }
        public static Duration operator -(Duration a, Duration b)
        {
            Duration c = new Duration();
            c.Hours = (a?.Hours ?? 0) - (b?.Hours ?? 0);
            c.Minutes = (a?.Minutes ?? 0) - (b?.Minutes ?? 0);
            c.Seconds = (a?.Seconds ?? 0) - (b?.Seconds ?? 0);
            return c;
        }
        public static Duration operator ++(Duration a)
        {
            return new Duration() {

                Minutes = (a?.Minutes ?? 0) + 1
            };
        }
        public static Duration operator --(Duration a)
        {
            return new Duration()
            {

                Minutes = (a?.Minutes ?? 0) - 1
            };
        }

        public static bool operator >(Duration a, Duration b)
        {

            if (a?.Hours == b?.Hours)
                return a?.Hours > b?.Hours;
            else if (a?.Minutes == b?.Minutes)
                return a?.Minutes > b?.Minutes;
            else
                return a?.Seconds > b?.Seconds;
        }
        public static bool operator <(Duration a, Duration b)
        {

            if (a?.Hours == b?.Hours)
                return a?.Hours < b?.Hours;
            else if (a?.Minutes == b?.Minutes)
                return a?.Minutes < b?.Minutes;
            else
                return a?.Seconds < b?.Seconds;
        }
        public static bool operator >=(Duration a, Duration b)
        {

            if (a?.Hours >= b?.Hours)
                return a?.Hours >= b?.Hours;
            else if (a?.Minutes >= b?.Minutes)
                return a?.Minutes >= b?.Minutes;
            else
                return a?.Seconds >= b?.Seconds;
        }
        public static bool operator <=(Duration a, Duration b)
        {

            if (a?.Hours <= b?.Hours)
                return a?.Hours <= b?.Hours;
            else if (a?.Minutes <= b?.Minutes)
                return a?.Minutes <= b?.Minutes;
            else
                return a?.Seconds <= b?.Seconds;
        }


        public static implicit operator bool(Duration a)
        {
            return a is not null;
        }

        public static implicit operator DateTime(Duration v)
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, v?.Hours ?? 0, v?.Minutes ?? 0, v?.Seconds ?? 0);
        }

        public static implicit operator Duration(int v)
        {
            return new Duration(v);
        }


        #endregion

    }
}
