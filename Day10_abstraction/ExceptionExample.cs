using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_abstraction
{
    class ExceptionExample
        //Demo of try-catch in c#
    {
        static void Main(string[] args)
        {
            int num1, num2, ans;
            try
            {
                num1 = 10;
                num2 = 0;
                ans = num1 / num2;
                Console.WriteLine("Answer = " + ans);
                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Cannot Divide number by zero");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
