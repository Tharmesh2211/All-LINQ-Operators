using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_SET_OPERATORS
{

    //public class EmployeeDistinct
    //{

    //    public int emp_id
    //    {
    //        get;
    //        set;
    //    }

    //    public string emp_name
    //    {
    //        get;
    //        set;
    //    }

    //    public string emp_gender
    //    {
    //        get;
    //        set;
    //    }

    //    public string emp_hire_date
    //    {
    //        get;
    //        set;
    //    }

    //    public int emp_salary
    //    {
    //        get;
    //        set;
    //    }
    //}

    //class GFG
    //{

    //    //Main method
    //    static public void Main()
    //    {
    //        List<EmployeeDistinct> emp = new List<EmployeeDistinct>() {

    //        new EmployeeDistinct() {emp_id = 209, emp_name = "Anjita", emp_gender = "Female",
    //                                emp_hire_date = "12/3/2017", emp_salary = 20000},

    //        new EmployeeDistinct() {emp_id = 210, emp_name = "Soniya", emp_gender = "Female",
    //                                emp_hire_date = "22/4/2018", emp_salary = 30000},

    //        new EmployeeDistinct() {emp_id = 211, emp_name = "Rohit", emp_gender = "Male",
    //                            emp_hire_date = "3/5/2016", emp_salary = 40000},

    //        new EmployeeDistinct() {emp_id = 212, emp_name = "Supriya", emp_gender = "Female",
    //                                emp_hire_date = "4/8/2017", emp_salary = 40000},

    //        new EmployeeDistinct() {emp_id = 213, emp_name = "Anil", emp_gender = "Male",
    //                            emp_hire_date = "12/1/2016", emp_salary = 40000},

    //        new EmployeeDistinct() {emp_id = 214, emp_name = "Anju", emp_gender = "Female",
    //                            emp_hire_date = "17/6/2015", emp_salary = 50000},
    //    };


    //        var res = emp.Select(e => (e.emp_salary),(e,slaray)=>Select(s => new { e.emp_id, Salary = s })).Distinct();
    //        Console.WriteLine("Employee ID and Salary: ");

    //        foreach (var val in res)
    //        {
    //            Console.WriteLine($"ID: {val.emp_id}, Salary: {val.Salary}");
    //        }
    //    }
    //}


    public class A
    {
        public static void Print(IEnumerable res)
        {
            foreach (var val in res)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("------------------------------------");
        }

        //public static void Main(string[] args)
        //{
        //    int[] num = { 1, 2, 3, 4, 5, 2, 3, 4, 4, 5 };//1,2,3,4,5
        //    var res = num.Distinct();
        //    Print(res);

        //    char[] Characters = { 'a', 'b', 'c', 'a', 'c', 'a' };//a,b,c
        //    Print(Characters);
        //    var res1 = Characters.Distinct();
        //    Print(res1);

        //    object[] obj = { 1, 'A', 'B', 'b', 3.2, "thar", "Tharmesh", 1, 2, 3, 'B' };
        //    var res2 = obj.Distinct();//1,A,B,b,3.2,thar,tharmesh,2,3
        //    Print(res2);
        //}
    }
}