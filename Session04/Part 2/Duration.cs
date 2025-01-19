using System;
using System.Collections.Generic;
using System.Linq;
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

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int seconds)
        {
            Hours = seconds / 3600;
            Minutes=(seconds%3600) / 60;
            Seconds = seconds > 3600 ? seconds % (Hours * 60) : seconds; 
        }
    }
}
