using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_GROUPING_OPERATORS
{
    public static class EmployeeList
    {
        static EmployeeList()
        {
            Console.WriteLine("Code is Executing...");
            Console.WriteLine("---------------------------------");

        }

        static List<Employee> employeeList = new List<Employee>()
        {
            new Employee { Emp_ID = 1, Emp_Name = "Sitha", DOB = new DateTime(1990, 5, 15) , Age = 15},
            new Employee { Emp_ID = 2, Emp_Name = "Allwyn", DOB = new DateTime(1985, 8, 22), Age = 21 },
            new Employee { Emp_ID = 3, Emp_Name = "Sairam", DOB = new DateTime(1992, 3, 10), Age = 18 },
            new Employee { Emp_ID = 4, Emp_Name = "Ganesh", DOB = new DateTime(1988, 11, 5), Age = 26 },
            new Employee { Emp_ID = 5, Emp_Name = "Parthiban", DOB = new DateTime(1988, 11, 5), Age = 29 },
            new Employee { Emp_ID = 6, Emp_Name = "Kumar", DOB = new DateTime(1992, 3, 10), Age = 18 },
            new Employee { Emp_ID = 7, Emp_Name = "Ravi", DOB = new DateTime(1988, 11, 5), Age = 26 },
            new Employee { Emp_ID = 8, Emp_Name = "Jai", DOB = new DateTime(1988, 11, 5), Age = 29 }


        };
        
        public static void GroupByQuery()
        {
            Console.WriteLine("\nUsing GroupBy Query  :\n");
            var res =  from emp in employeeList
                   group emp by emp.Age;
            foreach(var val in res )
            {
                Console.WriteLine( "Age    :   "+val.Key );
                foreach(var emp in val)
                {
                    Console.WriteLine("Employee Name   :  "+emp.Emp_Name);
                }
                Console.WriteLine();    
            }
            Console.WriteLine("---------------------------------");

        }

        public static void GroupByMethod()
        {
            Console.WriteLine("\nUsing GroupBy Method  :\n");
            var res = employeeList.GroupBy( emp => emp.Age);
            foreach (var val in res)
            {
                Console.WriteLine("Age    :   " + val.Key);
                foreach (var emp in val)
                {
                    Console.WriteLine("Employee Name   :  " + emp.Emp_Name);
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------") ;
        }
        public static void ToLookUp()
        {
            Console.WriteLine("\nUsing ToLookup Method  :\n");

            var res = employeeList.ToLookup(emp => emp.Age);
            foreach (var val in res)
            {
                Console.WriteLine("Age    :   " + val.Key);
                foreach (var emp in val)
                {
                    Console.WriteLine("Employee ID   :   "+emp.Emp_ID+"       Employee Name   :  " + emp.Emp_Name);
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------");
        }

    }
}
