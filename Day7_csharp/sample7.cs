using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_csharp
{
    class sample7
    {
        public static void Main()
        {
            int i;
            for (i = 0; i <= 10; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine("value is : " + i);

            }
            Console.ReadLine();

        }
    }
}