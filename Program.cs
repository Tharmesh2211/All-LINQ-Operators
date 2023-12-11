
using Joins_Operators;
using System;
using System.Collections.Generic;

namespace LINQ_Operators
{
    public class Program
    {
        static void Main(string[] args)
        {
            int op = Menu();

            switch (op)
            {
                case 1: Projection();
                    break;

                case 2: Filtering(); 
                    break;

                case 3: Aggregate();
                    break;

                case 4: Grouping();
                    break;

                case 5: Set();
                    break;

                case 6: Sorting();
                    break;

                case 7: TakeSkip();
                    break;

                case 8: Joins();
                    break;
            }
        }
        public static int Menu()
        {
            int op = 0;
            try
            {
                Console.WriteLine("============================================");
                Console.WriteLine("            LINQ ALL OPERATORS              ");
                Console.WriteLine("============================================");
                Console.WriteLine(" 1.  PROJECTION OPERATOR                    ");
                Console.WriteLine(" 2.  FILTERING OPERATOR                     ");
                Console.WriteLine(" 3.  AGGREGATE OPERATOR                     ");
                Console.WriteLine(" 4.  GROUPING OPERATOR                      ");
                Console.WriteLine(" 5.  SET OPERATOR                           ");
                Console.WriteLine(" 6.  SORTING OPERATOR                       ");
                Console.WriteLine(" 7.  TAKE SKIP OPERATOR                     ");
                Console.WriteLine(" 8.  JOINS OPERATOR                         ");
                Console.WriteLine("============================================\n");
                Console.Write("ENTER YOUR OPTION   >  ");
                op = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return op;
        }

        public static void Projection()
        {
            Console.Clear();
            LINQ.Select_Method.EmployeeList employee = new LINQ.Select_Method.EmployeeList();
            employee.SelectQuery();
            employee.SelectQueryAll();
            employee.SelectMethodAll();
            employee.SelectMethodSpecific();
            Console.WriteLine("\n************************************************************************\n");


            Console.WriteLine("\nSelect method Output :\n");
            Console.WriteLine("\n************************************************************************\n");
            LINQ.EmployList employList = new LINQ.EmployList();
            employList.SelectManySpecificValue();
            employList.SelectManyQuery();
            employList.SelectManyMethod();
        }

        public static void Filtering()
        {
            Console.Clear();
            IEnumerable<LINQ_FILTERING_OPERATORS.Student> students = LINQ_FILTERING_OPERATORS.StudentList.whereQuery();
            LINQ_FILTERING_OPERATORS.StudentList.PrintDetail(students);

            students = LINQ_FILTERING_OPERATORS.StudentList.WhereMethod();
            LINQ_FILTERING_OPERATORS.StudentList.PrintDetail(students);

            students = LINQ_FILTERING_OPERATORS.StudentList.OfType();
            LINQ_FILTERING_OPERATORS.StudentList.PrintDetail(students);

        }

        public static void Aggregate()
        {
            Console.Clear();
            LINQ_AGGREEGATE_OPERATORS.StudentList studentList = new LINQ_AGGREEGATE_OPERATORS.StudentList();
            studentList.Calculate();
        }

        public static void Grouping()
        {
            Console.Clear();
            LINQ_GROUPING_OPERATORS. EmployeeList.GroupByQuery();
            LINQ_GROUPING_OPERATORS.EmployeeList.GroupByMethod();
            LINQ_GROUPING_OPERATORS.EmployeeList.ToLookUp();
        }

        public static void Set()
        {
            Console.Clear();
            LINQ_SET_OPERATORS.Set_Operation_With_Class.EmployMain emp =
                new LINQ_SET_OPERATORS.Set_Operation_With_Class.EmployMain();

            emp.Union();
            emp.Intersect();
            emp.Except();
            emp.Distinct();
        }

        public static void Sorting()
        {
            Console.Clear();
            LINQ_SORTING_OPERATORS.StudentList studentList = new LINQ_SORTING_OPERATORS.StudentList();
            IEnumerable<LINQ_SORTING_OPERATORS.Student> stud = studentList.SortAscending();
            studentList.Print(stud);
            stud = studentList.SortDescending();
            studentList.Print(stud);
            stud = studentList.ThenBy();
            studentList.Print(stud);
            stud = studentList.ThenByDescending();
            studentList.Print(stud);
            stud = studentList.Reverse();
            studentList.Print(stud);
        }

        public static void TakeSkip()
        {
            Console.Clear();
            Take_and_Skip_Operators.CompanyList companyList = new Take_and_Skip_Operators.CompanyList();
            IEnumerable<Take_and_Skip_Operators.Company> take = companyList.Take();
            companyList.Print(take);

            IEnumerable<Take_and_Skip_Operators.Company> skip = companyList.Skip();
            companyList.Print(skip);
        }

        public static void Joins()
        {
            Console.Clear();
            Console.WriteLine("\n========================\n");
            ProgramMain.InnerJoin();
            Console.WriteLine("\n========================\n");
            ProgramMain.LeftJoin();
            Console.WriteLine("\n========================\n");
            ProgramMain.RightJoin();
            Console.WriteLine("\n========================\n");
            ProgramMain.CrossJoin();
            Console.WriteLine("\n========================\n");
        }
    }
}
