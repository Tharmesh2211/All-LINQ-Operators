using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_SET_OPERATORS
{
   
    class Except
    {
        public static void Print(IEnumerable res)
        {
            foreach (var s in res)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("====================================");
        }
        //static void Main()
        //{

        //    char[] s1 = { 'm', 'q', 'o', 's', 'y', 'a' };
        //    char[] s2 = { 'p', 't', 'r', 's', 'y'};

        //    Console.WriteLine("Sequence 1 is: ");

        //    Print(s1);

        //    Console.WriteLine("Sequence 2 is: ");

        //    Print(s2);


        //    var result = s1.Except(s2);

        //    Console.WriteLine("New Sequence: ");

        //    Print(result);

            
        //}
    }

}
