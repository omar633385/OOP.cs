using Session_6.First_Project;
using Session_6.Second_Project;
using Session_6.ThirdProject.Discounts;
using Session_6.ThirdProject.User;

namespace Session_6
{
    internal class Program
    {
        [Flags]
        enum User
        {
            Regular=1, Premium=2, Guest=4
        }
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
            try
            {
                bool flag;
                User user;
                decimal price;
                int quantity;
                do
                {
                    Console.WriteLine($"Enter Type Of User");
                    Console.WriteLine(" Hint : 1 for Regular , 2 for Premium , 4 forGuest");
                    flag = Enum.TryParse(Console.ReadLine(), out user);

                } while (!flag);
                do
                {
                    Console.WriteLine($"Enter Price");
                    flag = decimal.TryParse(Console.ReadLine(), out price);

                } while (!flag || price <= 0) ;
                do
                {
                    Console.WriteLine($"Enter Quantity");
                    flag = int.TryParse(Console.ReadLine(), out quantity);

                } while (!flag || quantity <= 0);
                if (user == User.Guest)
                {
                    GuestUser guestUser = new GuestUser();
                    decimal discount=guestUser.GetDiscount().CalculateDiscount(price, quantity);
                    Console.Write($"Total Discount is:{discount}\n");
                    Console.Write($"Total Price is :{price*quantity-discount}");

                }
                else if (user == User.Premium)
                {
                    PremiumUser premiumUser = new PremiumUser();
                    decimal discount =premiumUser.GetDiscount().CalculateDiscount(price, quantity);
                    Console.Write($"Total Discount is:{discount}\n");
                    Console.Write($"Total Price is :{price*quantity - discount}");
                }
                else
                {
                    RegularUser regularUser = new RegularUser();
                    decimal discount = regularUser.GetDiscount().CalculateDiscount(price,quantity);
                    Console.Write($"Total Discount is:{discount}\n");
                    Console.Write($"Total Price is :{price*quantity -discount}");
                }

            }
            catch (Exception ex) {

                Console.WriteLine(ex.Message);
            }
            

            #endregion


        }
    }
}
