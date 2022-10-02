using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_csharphandson
{
    class csharphandson2_p3
    {
        public int add()
        {
            int n1;
            int n2;
            int sum;
            

            Console.WriteLine("Enter 1st number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            n2 = Convert.ToInt32(Console.ReadLine());
            sum = (n1 + n2);
            return sum;
        }

        public static void Main()
        {
            csharphandson2_p3 obj = new csharphandson2_p3();
            int result = obj.add();
            Console.WriteLine("The sum of the 2 number is: " + result);
        }
    }
}
