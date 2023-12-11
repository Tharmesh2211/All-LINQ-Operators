using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_SET_OPERATORS.Set_Operation_With_Class
{
    public class EmploySetOp
    {
        public void Method()
        {

        }
        public static List<Employee> employees1 = new List<Employee>
        {
            new Employee { EmployeeId = 1, Name = "Tharmesh" },
            new Employee { EmployeeId = 2, Name = "Sairam" },
            new Employee { EmployeeId = 3, Name = "Babu" },
            new Employee { EmployeeId = 3, Name = "Babu" },
            new Employee { EmployeeId = 6, Name = "Selvam" }
        };

        public static List<Employee> employees2 = new List<Employee>
        {
            new Employee { EmployeeId = 1, Name = "Tharmesh" },
            new Employee { EmployeeId = 3, Name = "Babu" },
            new Employee { EmployeeId = 4, Name = "Ganesh" },
            new Employee { EmployeeId = 4, Name = "Ganesh" },
            new Employee { EmployeeId = 5, Name = "Allwyn" }
        };

       
    }
}
