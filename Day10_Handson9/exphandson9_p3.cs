using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Handson9
{
    class exphandson9_p3 :ApplicationException
    {
        public exphandson9_p3(string message) : base(message)
        
        {

        }
        public static void Main()
        {
            string a;
            string b;
            int sum;
            try
            {
                Console.WriteLine("Please enter the first number");
                a = Console.ReadLine();
                Console.WriteLine("Please enter the second number");
                b = Console.ReadLine();
                sum = int.Parse(a + b);
                
                Console.WriteLine("sum : " + sum);
                if (string.IsNullOrEmpty(a))
                {
                    throw new exphandson9_p3("Please provide valid input");
                }
                if (string.IsNullOrEmpty(a))
                {
                    throw new exphandson9_p3("Please provide valid input");
                }
                string convertstr = Convert.ToString(sum);
            }
            catch (exphandson9_p3 ex)

            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
