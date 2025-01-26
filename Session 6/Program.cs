using Session_6.First_Project;
using Session_6.Second_Project;

namespace Session_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project

            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString());


            #region 3.	Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).
            //Point3D[] points = new Point3D[2];
            //for (int i = 0; i < points.Length; i++)
            //{
            //    try
            //    {
            //        int x, y, z;
            //        bool flag;
            //        Console.WriteLine($"Enter details for point {i + 1}:");

            //        do
            //        {
            //            Console.Write("x: ");
            //            flag = int.TryParse(Console.ReadLine(), out x);
            //            Console.Write("y: ");
            //            flag = int.TryParse(Console.ReadLine(), out y);
            //            Console.Write("z: ");
            //            flag = int.TryParse(Console.ReadLine(), out z);

            //            if (!flag)
            //            {
            //                Console.WriteLine("Invalid input. Please enter valid integers for x,y and z.");
            //            }
            //            points[i] = new Point3D()
            //            {
            //                X = x,
            //                Y = y,
            //                Z = z
            //            };

            //        } while (!flag);
            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine(ex.Message);
            //    }
            //}

            #endregion


            #region 4.	Try to use  ==If(P1 == P2)   Does it work properly? 
            //Console.WriteLine($"P1 hashcode:{points[0].GetHashCode()}");
            //Console.WriteLine($"P2 hashcode:{points[1].GetHashCode()}");

            //if (points[0] == points[1])
            //{
            //    Console.WriteLine("They Are Equal");
            //}
            //else
            //{
            //    Console.WriteLine("They are not Equal");
            //}
            //It Works As they are two different Objects Event if they have the same state 
            #endregion



            #region 5.	Define an array of points and sort this array based on X & Y coordinates.

            //Point3D[] points3ds =
            //    {
            //        new Point3D { X = 3, Y = 5, Z = 1 },
            //        new Point3D { X = 1, Y = 2, Z = 3 },
            //        new Point3D { X = 3, Y = 4, Z = 2 },
            //        new Point3D { X = 1, Y = 1, Z = 4 }

            //    };
            //Array.Sort(points3ds, new Point3DComparer());

            //Console.WriteLine("After Sorting");
            //foreach (var item in points3ds)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #endregion

            #region SecondProject

            //Console.WriteLine(Maths.Add(1, 0));
            //Console.WriteLine(Maths.Subtract(1, 0));
            //Console.WriteLine(Maths.Multiply(1, 0));    
            //Maths.Divide(1, 0);

            #endregion

            #region ThirdProject

            #endregion


        }
    }
}
