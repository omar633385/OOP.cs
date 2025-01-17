using System.Linq.Expressions;

namespace Session01
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            #region 1	Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.


            //Point[] points = new Point[2];
            //for (int i = 0; i < points.Length; i++)
            //{
            //    try
            //    {
            //        int x,y;
            //        bool flag1,flag2;
            //        Console.WriteLine($"Enter details for point {i + 1}:");

            //        do
            //        {
            //            Console.Write("x: ");
            //            flag1 = int.TryParse(Console.ReadLine(), out x);
            //            Console.Write("y: ");
            //            flag2 = int.TryParse(Console.ReadLine(), out y);

            //            if (!flag1 || !flag2)
            //            {
            //                Console.WriteLine("Invalid input. Please enter valid integers for x and y.");
            //            }

            //        } while (!(flag1&&flag2));

            //        points[i] = new Point()
            //        {
            //            X=x,
            //            Y=y
            //        };
            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine(ex.Message);
            //    }

            //}
            //double distance = Math.Sqrt(Math.Pow(Math.Abs(points[1].X - points[0].X), 2) + Math.Pow(Math.Abs(points[1].Y - points[0].Y), 2));
            //distance = Math.Round(distance, 2);
            //Console.WriteLine($"distance between two Points is : {distance}");


            #endregion

            #region 2	Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            Person[] persons = new Person[3];

            for (int i = 0; i < persons.Length; i++)
            {
                try
                {
                    bool flag;
                    int age;
                    string name;
                    Console.WriteLine($"Enter details for person {i + 1}:");

                    do
                    {
                        Console.Write("Name: ");
                        name = Console.ReadLine();

                    }
                    while (string.IsNullOrEmpty(name));

                    do
                    {
                        Console.Write("Age: ");
                        flag = int.TryParse(Console.ReadLine(), out age);
                        if (!flag)
                            Console.WriteLine("Invalid input. Please enter valid integers for Age.");
                    } while (!flag);
                   

                    persons[i] = new Person()
                    {
                        Age = age,
                        Name = name
                    };
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            int oldestIndex = 0; 
            for (int i = 1; i < persons.Length; i++)
            {
                if (persons[i].Age > persons[oldestIndex].Age)
                {
                    oldestIndex = i; 
                }
            }
            Console.WriteLine($"Oldest Person: Name = {persons[oldestIndex].Name}, Age = {persons[oldestIndex].Age}");

        }

        #endregion
    }
    }

