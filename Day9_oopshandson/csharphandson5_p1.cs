using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_oopshandson
{
    class csharphandson5_p1
    {
        public static void Main()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Please enter your date of joining in 'mm/dd/yyyy' format in you current organization");
            string s = Convert.ToString(Console.ReadLine());
            DateTime day1 = DateTime.Parse(s, CultureInfo.CreateSpecificCulture("en-US"));
            TimeSpan diff = today - day1;

            Console.WriteLine("It has been {0} days since you joined your current organization", diff.Days);


        }
    }
}
