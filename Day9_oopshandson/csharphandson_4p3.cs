using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_oopshandson
{
    class csharphandson_4p3
    {
        static void constituncies()
        {
            int[]  con = new int[3];
            con[0] = 1000;
            con[1] = 1000;
            con[2] = 1000;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i+"-"+con[i]);
            }
            Console.WriteLine("Please provide the constituency number for which the vote count should be modified:");
            int connum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please provide the new vote count:");
            int concount = Convert.ToInt32(Console.ReadLine());

        }
        public static void Main()
        {
            constituncies();
        }
    }
}
