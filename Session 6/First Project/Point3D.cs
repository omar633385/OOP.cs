using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session_6.First_Project
{
    internal class Point3D:ICloneable
    {
        //1.	Define 3D Point Class and the basic Constructors(use chaining in constructors).
        #region Properties

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        #endregion

        #region Constructors
      

        public Point3D(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Point3D(int x, int y, int z) : this(x, y)
        {

            Z = z;
        }

        public Point3D()
        {
        }
        #endregion

        #region Methods
        //2.	Override the ToString Function to produce this output
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public int CompareTo(object? obj)
        {

            Point3D point = (Point3D)obj;
            if (this.X > point.X && this.Y>point.Y ) return 1;
            else if (this.X < point.X && this.Y < point.Y) return -1;
            else return 0;
        }

        public object Clone()
        {
            return new Point3D()
            {
                X = this.X,
                Y = this.Y,
                Z = this.Z
            };
        }


        #endregion

    }
}
