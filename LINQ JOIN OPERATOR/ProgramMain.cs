using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Joins_Operators
{
    public static class ProgramMain
    {
        public static List<College> colleges = new List<College>
        {
            new College { CollegeId = 1, CollegeType = "Engineering College" },
            new College { CollegeId = 2, CollegeType = "Arts College" },
            new College { CollegeId = 3, CollegeType = "Medical College" },
            new College { CollegeId = 4, CollegeType = "Law College" }

        };

        public static List<Department> departments = new List<Department>
        {
            new Department { DepartmentId = 101, DepartmentName = "CS Engineering", CollegeId = 1 },
            new Department { DepartmentId = 102, DepartmentName = "Mechanical Engineering", CollegeId = 1 },
            new Department { DepartmentId = 103, DepartmentName = "Zoology", CollegeId = 2 },
            new Department { DepartmentId = 104, DepartmentName = "Chemistry", CollegeId = 3 },
            new Department { DepartmentId = 105, DepartmentName = "Physics", CollegeId = 2 },
            new Department { DepartmentId = 106, DepartmentName = "Tamil", CollegeId = 8 }

        };

        public static List<Student> students = new List<Student>
        {
            new Student {S_Id = 20, S_Name = "Tharmesh", Depart_ID = 101, Clg_ID = 1},
            new Student {S_Id = 21, S_Name = "Viswa", Depart_ID = 105, Clg_ID = 2},
            new Student {S_Id = 22, S_Name = "Ananth", Depart_ID = 104, Clg_ID = 3},
            new Student {S_Id = 23, S_Name = "Pradeep",Depart_ID = 101, Clg_ID = 1},
            new Student {S_Id = 24, S_Name = "Ganesh", Depart_ID = 100, Clg_ID = 8 },
            new Student {S_Id = 25, S_Name = "Allwyn", Depart_ID = 103, Clg_ID = 2}
        };

        public static void InnerJoin()
        {
            var innerJoin = from clg in colleges
                            join dep in departments
                            on clg.CollegeId equals dep.CollegeId
                            select new { Clg = clg.CollegeId, Dep = dep.DepartmentId, Dep_Name = dep.DepartmentName };
            //foreach(var clg in innerJoin)
            //{
            //    Console.WriteLine(clg.Clg + "     "+clg.Dep+"     "+clg.Dep_Name);
            //}

            var innerJoin3 = from clg in colleges
                             join dep in departments
                             on clg.CollegeId equals dep.CollegeId
                             join std in students on dep.DepartmentId equals std.Depart_ID
                             select new
                             {
                                 ClgID = clg.CollegeId,
                                 DepName = dep.DepartmentName,
                                 StudName = std.S_Name
                             };
            foreach (var clg in innerJoin3)
            {
                Console.WriteLine(clg.ClgID + "     " + clg.DepName + "     " + clg.StudName);
            }
        }

        public static void LeftJoin()
        {
            var leftJoin =  from clg in colleges
                   join dep in departments
                   on clg.CollegeId equals dep.CollegeId into AddIntoGroup1
                   from ss1 in AddIntoGroup1.DefaultIfEmpty()
                   join std in students
                   on clg.CollegeId equals std.Clg_ID into AddIntoGroup2
                   from ss2 in AddIntoGroup2.DefaultIfEmpty()

                   select new
                   {
                       ClgID = clg.CollegeId,
                       DepName = ss1 != null ? ss1.DepartmentName : "NULL",
                       Std_Name = ss1 != null ? ss2.S_Name : "NULL"
                   };
            foreach(var clg in  leftJoin)
            {
                Console.WriteLine(clg.ClgID+"     "+clg.DepName+"     "+clg.Std_Name);
            }
        }

        public static void RightJoin()
        {
            var rightJoinQuery = from college in colleges
                                 join department in departments
                                 on college.CollegeId equals department.CollegeId into collegeDepartments
                                 from cd in collegeDepartments.DefaultIfEmpty()
                                 join student in students
                                 on cd?.DepartmentId equals student.Depart_ID into departmentStudents
                                 from ds in departmentStudents.DefaultIfEmpty()
                                 select new
                                 {
                                     CollegeId = college != null ? college.CollegeId : 0,
                                     CollegeName = college != null ? college.CollegeType: "null",
                                     DepartmentId = cd != null ? cd.DepartmentId : 0,
                                     DepartmentName = cd != null ? cd.DepartmentName : "null",
                                     StudentId = ds != null ? ds.S_Id : 0,
                                     StudentName = ds != null ? ds.S_Name : "null"
                                 };

            foreach (var result in rightJoinQuery)
            {
                Console.WriteLine($"CollegeId: {result.CollegeId}, CollegeName: {result.CollegeName}, " +
                                  $"DepartmentId: {result.DepartmentId}, DepartmentName: {result.DepartmentName}, " +
                                  $"StudentId: {result.StudentId}, StudentName: {result.StudentName}");
            }
        }
       
        public static void CrossJoin()
        {
            var cross = from clg in colleges
                        from dept in departments
                        from stu in students
                        select new
                        {
                            CollegeId = clg.CollegeId,
                            CollegeName = clg.CollegeType,
                            DepartmentId = dept.DepartmentId,
                            DepartmentName = dept.DepartmentName,
                            StudentId = stu.S_Id,
                            StudentName = stu.S_Name
                        };

            foreach( var clg in cross)
            {
                Console.WriteLine(clg.CollegeName + "         "+clg.StudentName+"          "+clg.DepartmentName );
            }
        }


    }
}
