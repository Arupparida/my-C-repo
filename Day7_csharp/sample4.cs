using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_csharp
{
    class sample4
    {
        public static void Main()
        {
            int num = 1;
            while (num <=5)
            {
                Console.WriteLine("Number = " + num.ToString()); //Don't forget to convert int type to string as by default
                //the output in c# and js will concatenate the int with the string provided.
                num++;
            }
            Console.ReadLine();
        }
    }
}
