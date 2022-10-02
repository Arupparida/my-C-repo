using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


enum Mobile
{
    vivo = 23,
    sony,
    oppo,
    iphone,
    samsung
}

namespace Day7_csharp
{
    enum Cars
    {
        ford,
        mercedes
    }
    class sample9
    {
        public static void Main()
        {
            Console.WriteLine(Mobile.iphone);
            Console.WriteLine((int)Mobile.iphone);
            Console.WriteLine(Cars.ford);
            Console.WriteLine((int)Cars.ford);
            Console.ReadLine();
        }
    }
}
