using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Session03
{
    #region Enums
    [Flags]
    public enum Gender:byte
    {
        M=1, F=2
    }
    [Flags]
    public enum SecurityPrivileges:byte
    {
        guest=1, Developer=2, secretary=4, DBA=8
    } 
    #endregion

    internal class Employee
    {

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Gender Gender { get; set; }
        public SecurityPrivileges SecurityPrivilege { get; set; }
        public HiringDate HiringDate { get; set; }

        #endregion
        #region ctor
        public Employee(int id, string name, double salary, Gender gender, SecurityPrivileges securityPrivilege, HiringDate hiringDate)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Gender = gender;
            SecurityPrivilege = securityPrivilege;
            HiringDate = hiringDate;
        }

        public Employee(int id, string name, double salary, Gender gender, SecurityPrivileges securityPrivilege) : this(hiringDate: new HiringDate())
        {
            Id = id;
            Name = name;
            Salary = salary;
            Gender = gender;
            SecurityPrivilege = securityPrivilege;
        }

        public Employee(HiringDate hiringDate)
        {
            HiringDate = hiringDate;
        }

        #endregion

        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Salary:{Salary.ToString("C")} Gender:{Gender} SecurityLevel:{SecurityPrivilege} HiringDate:{HiringDate}";
        }
        public static Employee[] Sort(Employee[] employees)
        {
            int n = employees.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Convert HiringDates to DateTime for comparison
                    DateTime date1 = employees[j].HiringDate.ToDateTime();
                    DateTime date2 = employees[j + 1].HiringDate.ToDateTime();

                    // Swapping 
                    if (date1 > date2)
                    {
                        var temp = employees[j];
                        employees[j] = employees[j + 1];
                        employees[j + 1] = temp;
                    }
                }

            }
            return employees ;
        }

    }
    
}
