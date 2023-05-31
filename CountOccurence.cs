using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharpPlayground
{

    /*Problem Statement  -  Write a program to count the occurrences of each character*/

    /* There are three ways tod this problem 
     * 1. Using recursion
     * 2. Using dictionary 
     * 3. Using the normal looping method 
     */
    class CountOccurence
    {
        public static void Main()
        {

            string str = "Website";
            Console.WriteLine("String: " + str);
            while (str.Length > 0)
            {
                Console.Write(str[0] + " = ");
                int cal = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        cal++;
                    }
                }
                Console.WriteLine(cal);
                str = str.Replace(str[0].ToString(), string.Empty);
                //Console.WriteLine(str);
            }
            Console.ReadLine();



            /*
            Console.Write("Pls enter a string:");
            string str = Console.ReadLine();
            //Convert str to chararray
            Array[] arr = str.Split();
            Array[] arr = new Array['A','R','U','P',]

            foreach( chr in arr)
            {

            }*/
        }
    }
}
