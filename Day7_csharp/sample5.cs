using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_csharp
{
    class sample5
    {
        public static void Main() 
        {
            int num = 0;
            do
            {
                Console.WriteLine("Number  =" + num.ToString());
                num += 2;

            } while (num <= 10);
            Console.ReadLine();
        }
    }
}
