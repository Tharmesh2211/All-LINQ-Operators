using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_AGGREEGATE_OPERATORS
{
    public class StudentList
    {
        public List<Student> students = new List<Student>()
        {
            new Student() {ID = 1, Name ="Sairam", Age = 23, Marks = new List<int>{50,70,80,90,68}},
            new Student() {ID = 2, Name ="Danesh", Age = 22, Marks = new List<int>{70,20,51,68,47,90}},
            new Student() {ID = 3, Name ="Allwyn", Age = 27, Marks = new List<int>{52,77,89,84,32}},
            new Student() {ID = 4, Name ="Ganesh", Age = 27, Marks = new List<int>{70,58,62,14,66}},
            new Student() {ID = 5, Name ="Sathish", Age = 24, Marks = new List<int>{50,60,65,97,62}},
            new Student() {ID = 6, Name ="Gopinath", Age = 35, Marks = new List<int>{30,21,67,88,61}}
        };

        public void Calculate()
        {
            int MinMark = 35; 

            foreach (var student in students)
            {
                int TotalMarksCount = student.Marks.Count();

                int passedMarksCount = student.Marks.Count(mark => mark >= MinMark);
                
                int TotalSum = student.Marks.Sum();
                
                double Average = student.Marks.Average();
                
                int min = student.Marks.Min();
                
                int max = student.Marks.Max();
                
                string Result = CheckResult(TotalMarksCount, passedMarksCount) ? "Pass" : "Fail";
                
                Console.WriteLine("ID : {0}  \nName : {1}  \nNo Of Subject : {2}   \nTotalMark :  {3}  \nAverage :  {4}   \nResult :  {5} " +
                    "\nLowest Mark :  {6}   \nHighest Mark :  {7}\n",
                    student.ID,student.Name,TotalMarksCount,TotalSum,Average,Result,min,max);

                Console.WriteLine("\n= = = = = = = = = = = = = = = = = = = = = = =\n");
            }

        }

        public bool CheckResult(int Totalmarks, int passedmark)
        {
            return Totalmarks == passedmark;
        }
    }
}
