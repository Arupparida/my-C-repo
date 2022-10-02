using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_csharp
{
    class sample10
    {
        public static void Main()
        {
            int[] numbers = new int[5];
            int[] num = new int[] { 10, 20, 30, 40, 50 };
            int[] nums = { 1, 2, 3, 4, 5 };
            //assign value to array element
            numbers[0] = 55;
            numbers[1] = 20;
            numbers[2] = 10;
            numbers[3] = 5;
            numbers[4] = 25;
            //print the value of the array
            for (int i = 0; i< numbers.Length;i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
            //Do the same with string type and double type arrays.
        }
    }
}
