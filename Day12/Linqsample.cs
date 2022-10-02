using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    class Linqsample
    {
        static void Main()
        {
            //THE threeparts of a LINQ Query:
            //1. Data source.
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            //2.Query creation
            //numQuery is an IEnumberabe<int>
            var numQuery = from num in numbers
                           where (num % 2) == 0
                           select num;
            //3.Query execution
            //deferred execution
            foreach(var num in numQuery)
            {
                Console.WriteLine("{0}", num);

            }
            Console.WriteLine("\n--------------------\n");
            //printing total even number -count
            //Immediate execution
            int evenNumCount = numQuery.Count();
            Console.WriteLine("Total even numbers = " + evenNumCount.ToString());

            //sum of even numbers
            int evenNumTotal = numQuery.Sum();
            Console.WriteLine("Total of even Number = " + evenNumTotal.ToString());

            Console.ReadLine();


        }
    }
}
