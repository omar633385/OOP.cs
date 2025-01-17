namespace Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];
            for (int i = 0; i < EmpArr.Length; i++)
            {
                try
                {
                    bool flag;
                    int id;
                    string name;
                    double salary;
                    Gender gender;
                    SecurityPrivileges level;
                    int day, month, year;
                    Console.WriteLine($"Enter details for Employee {i + 1}:");
                    do
                    {
                        Console.WriteLine($"Enter Id Of Employee {i + 1} ");
                        flag = int.TryParse(Console.ReadLine(), out id);

                    } while (!flag);
                    do
                    {
                        Console.WriteLine($"Enter Name Of Employee {i + 1} ");
                        name = Console.ReadLine();

                    } while (string.IsNullOrEmpty(name));
                    do
                    {
                        Console.WriteLine($"Enter Salary Of Employee {i + 1} ");
                        flag = double.TryParse(Console.ReadLine(), out salary);

                    } while (!flag);

                    do
                    {
                        Console.WriteLine($"Enter Gender Of Employee {i + 1} ");
                        Console.WriteLine(" Hint : 1 for Male , 2 for Female"); 
                        flag = Enum.TryParse(Console.ReadLine(), out gender); 

                    } while (!flag);
                    do
                    {
                        Console.WriteLine($"Enter Security Level Of Employee {i + 1} ");
                        Console.WriteLine(" Hint : 1 for guest , 2 for Developer , 4 for secretary , 8 for DBA");
                        flag = Enum.TryParse(Console.ReadLine(), out level) ;

                    } while (!flag);
                    do
                    {
                        Console.WriteLine($"Enter day of HiringDate for Employee {i + 1} ");
                        flag = int.TryParse(Console.ReadLine(), out day);

                    } while (!flag);
                    do
                    {
                        Console.WriteLine($"Enter month of HiringDate for Employee {i + 1} ");
                        flag = int.TryParse(Console.ReadLine(), out month);

                    } while (!flag);
                    do
                    {
                        Console.WriteLine($"Enter year of HiringDate for Employee {i + 1} ");
                        flag = int.TryParse(Console.ReadLine(), out year);

                    } while (!flag);
                    EmpArr[i] = new Employee(id, name, salary, gender,level, new HiringDate(day, month, year));
                    Console.Clear();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            Console.Clear();
            Console.WriteLine("Employee Details:");
            Employee.Sort(EmpArr);
            foreach (var item in EmpArr)
            {
                Console.WriteLine(item);
            }
        }


    }

}


