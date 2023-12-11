using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ_SET_OPERATORS.Set_Operation_With_Class
{
    public class EmployMain : EmploySetOp
    {
        public List<Employee> employees3 = new List<Employee>();
        public List<Employee> employees4 = new List<Employee>();
        public List<Employee> employees5 = new List<Employee>();

        List<Employee> sortedEmployees, sortedEmployees2;
        public void Union()
        {
            // Merge Both List

            var unionResult = employees1.Union(employees2);
            //PrintEmployees(unionResult);

           sortedEmployees = unionResult.OrderBy(employee => employee.EmployeeId).ToList();

            Console.WriteLine("Union  :");

            PrintEmployees(RemoveDuplicateFromList(sortedEmployees, employees3));

            employees3.Clear();
        }

        public void Intersect()
        {
            //Show Common Values in both list
            sortedEmployees = employees1.OrderBy(employee => employee.EmployeeId).ToList();
            sortedEmployees2 = employees2.OrderBy(employee => employee.EmployeeId).ToList();

            
            Console.WriteLine("\nIntersection  :");

            PrintEmployees(CommonListValue(sortedEmployees, sortedEmployees2));
        }

        public void Except()
        {
            // Show non - Common values in 1st List
            employees3.Clear();
            employees4.Clear();

         
            Console.WriteLine("\nExcept (employees1 - employees2) :\n");

            PrintEmployees(ExceptList());
        }

        public void Distinct()
        {
            // Remove Duplicate values 

            Console.WriteLine("\nAfter Removing Duplicate Values ( employees1 ) :\n");

            PrintEmployees(Remove(employees1));
        }

        public void PrintEmployees(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"EmployeeId: {employee.EmployeeId}, Name: {employee.Name}");
            }
            Console.WriteLine();
        }

        public List<Employee> RemoveDuplicateFromList(List<Employee> employee1, List<Employee> employee3)
        {
            int i = 0;
            for ( i = 0; i < employee1.Count-1; i++)
            {
                if (employee1[i].EmployeeId != employee1[i + 1].EmployeeId)
                {
                    employee3.Add(employee1[i]);
                }
                
            }
            employee3.Add(employee1[i]);
            return employee3;
        }

        public List<Employee> CommonListValue(List<Employee> emp3, List<Employee> emp4)
        {
            employees3.Clear();

            List<Employee> list = RemoveDuplicateFromList(emp3, employees3);

            List<Employee> list2 = RemoveDuplicateFromList(emp4, employees4);
           
            for (int i = 0;i< list.Count; i++)
            {
                for(int j = 0;j < list2.Count;j++)
                {
                    if (list[i].EmployeeId == list2[j].EmployeeId)
                    {
                        employees5.Add(list[i]);
                        break;
                    }
                }
            }
            employees3.Clear();
            employees4.Clear();

            return employees5;
        }

        public List<Employee> ExceptList()
        {
            employees3.Clear();
            for (int i = 0;i < employees1.Count;i++)
            {
                bool Check = true;
                for(int j = 0;j < employees2.Count;j++)
                {
                    if (employees1[i].EmployeeId == employees2[j].EmployeeId)
                    {
                        Check = false;
                        break;
                    }
                }
                if(Check)
                {
                    employees3.Add(employees1[i]);
                }
            }
            return employees3;
        }

        public List<Employee> Remove(List<Employee> employee1)
        {
            employees5.Clear();
            int i = 0;
            for (i = 0; i < employee1.Count - 1; i++)
            {
                if (employee1[i].EmployeeId != employee1[i + 1].EmployeeId)
                {
                    employees5.Add(employee1[i]);
                }

            }
            employees5.Add(employee1[i]);
            return employees5;
        }
    }
}
