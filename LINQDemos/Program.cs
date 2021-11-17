using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] num = new int[] { 1, 2, 3, 4, 5, 7, 7, 8, 9, 10 };
            //for (int i = 0; i < num.Length;i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

             
            int[] num = new int[] { 1, 2, 3, 4, 5, 7, 7, 8, 9, 10 };
            // Query Suntax

            // Lazy Loading / Deferred loading
            var list = (from temp in num
                        select temp);
            foreach(int x in list)
                Console.WriteLine(x);

            // Early Loading
            int sum = (from temp in num
                       select temp).Sum();
            Console.WriteLine("Sum is "+ sum);

            double avg = (from temp in num
                       select temp).Average();

            Console.WriteLine("Average is " + avg);

            var evenList = (from x in num
                            where x % 2 == 0
                            select x);

            Console.WriteLine("Even Numbers are ");
            foreach(var x in evenList)
                Console.WriteLine(x);

            var evenlist = (from x in num
                            where x % 2 == 0
                            select x).ToList();

            // Method Syntax
            evenlist = num.Where(x => x % 2 == 0).ToList();
            Console.WriteLine("Even Numbers are ");
            foreach (var x in evenlist)
                Console.WriteLine(x);

            var evenlist1 = (from x in num
                            where x % 2 == 0
                            select x).ToArray();

            // Method Syntax

            string[] names = new string[] {"New Delhi", "Old Delhi",
            "Bombay","Calcutta","Kanpur"};

            //var nameslist = (from temp in names
            //                 select temp);

            var nameslist = names.ToList();
            nameslist = names.Select(x => x).ToList();
            Console.WriteLine("Names are " );
            foreach(string x in nameslist)
                Console.WriteLine(x);

            nameslist = (from temp in names
                         where temp.Contains("Delhi")
                         select temp).ToList();

            nameslist = names.Where(x => x.Contains("Delhi")).ToList();

            Console.WriteLine("Names which contains Delhi are ");
            foreach (string x in nameslist)
                Console.WriteLine(x);







        }
    }
}
