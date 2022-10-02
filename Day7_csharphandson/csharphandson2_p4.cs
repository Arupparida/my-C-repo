using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_csharphandson
{
    class csharphandson2_p4
    {
        double f;
        double c;
        public static void Main()
        {
            Console.WriteLine("Pleae enter temperature in degree Fahrenheit");
            double  f = Convert.ToDouble(Console.ReadLine());
            double c = (f - 32) * 5 / 9;
            Console.WriteLine("Temperature in degree celsius " + c);


        }
    }
}
