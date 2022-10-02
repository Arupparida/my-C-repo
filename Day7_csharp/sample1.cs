using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_csharp
{
    class sample1
    {
        public static void Main()
        {
            int Dayoftheweek;
            Console.WriteLine("Dayoftheweek");
            Dayoftheweek = Convert.ToInt32(Console.ReadLine());

            switch(Dayoftheweek)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                default:
                    Console.WriteLine("Wrong entry");
                    break;
            }
            Console.ReadLine();
        }
    }
}
