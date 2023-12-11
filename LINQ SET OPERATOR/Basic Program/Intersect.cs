using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_SET_OPERATORS
{
    internal class Intersect
    {
        public static void Print(IEnumerable res)
        {
            foreach (var s in res)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("====================================");
        }
        //static void Main(string[] args)
        //{
        //    object[] Eobj1 = { 1, "tharmesh", 23, 10000, "22/11/2001" };
        //    object[] Eobj2 = { 1, "Sairam", 23, 10000, "10/5/2000" };

        //    Console.WriteLine("Sequence 1 is: ");

        //    Print(Eobj1);

        //    Console.WriteLine("Sequence 2 is: ");

        //    Print(Eobj2);


        //    var Eobj3 = Eobj1.Intersect(Eobj2);
        //    Console.WriteLine("1 <-> 2 New Sequence: ");

        //    Print(Eobj3);

        //    var Eobj4 = Eobj2.Intersect(Eobj1);

        //    Console.WriteLine("2 <-> 1 Sequence: ");

        //    Print(Eobj4);
        //}
    }
}
