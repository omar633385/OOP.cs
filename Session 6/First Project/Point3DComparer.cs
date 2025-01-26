using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session_6.First_Project
{
    //  5.	Define an array of points and sort this array based on X & Y coordinates.
    internal class Point3DComparer: IComparer
    {
        public int Compare(object? x, object? y)
        {
            Point3D p1 = (Point3D)x;
            Point3D p2 = (Point3D)y;
            int compareX = p1.X.CompareTo(p2.X);
            if (compareX != 0)
                return compareX;

            // If X coordinates are equal, compare Y coordinates
            return p1.Y.CompareTo(p2.Y);

        }
    }
}
