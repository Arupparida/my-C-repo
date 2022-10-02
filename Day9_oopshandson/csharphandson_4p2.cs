using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_oopshandson
{
    class csharphandson_4p2
    {
        //code to perform Arithmetic progression of a series until a maximum value is reached
        /*public static void Main() {
            Console.WriteLine("Maximum value for progression");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0 ;
            int a = 1;
            do
            {
                Console.WriteLine(a);
                a= a + 2;
                i++;
            }
            while (i < n);
        */


        static void IncrementExample(ref int num)

        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i = i + 2;
                num++;
                
            }
            while (i <= num);
        }


        static void Main()
        {
            int num = 1;
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 20)
            {
                Console.WriteLine("Please provide the maximum value less than 20");
                
            }
            else
            {
                IncrementExample(ref num);
            }
            
            // num is now 2
        }
    }
}


    

