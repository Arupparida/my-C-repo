using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_csharp
{
    class sample11
    {
        void printArray(int[] arr)
        {
            Console.WriteLine("Printing array elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void Main()
        {
            int[] arr1 = { 25, 10, 20, 15, 40, 50 };
            int[] arr2 = { 12, 23, 44, 11, 54 };
            sample11 ao = new sample11();
            ao.printArray(arr1);//passing array to function
            ao.printArray(arr2);
            Console.ReadLine();
        }
    }
}
