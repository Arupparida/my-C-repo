using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_oopshandson
{
    class csharphandson_4p1
    {
        void time()
        {
            Console.WriteLine("Please Enter your date of joining in your current organization in 'mm/dd/yyyy' format");
            string dateimejoining =  Console.ReadLine();
            DateTime datetime2 = DateTime.Parse(dateimejoining);
            //string datestring = "Mon March 28 ,2022";
            DateTime currentdate1 = DateTime.Now;
            //Console.WriteLine(currentdate1.Subtract(datetime2));
            Console.WriteLine(currentdate1);
            Console.WriteLine(DateTime.Now.Subtract(datetime2).TotalDays);

            //DateTime date1 = new DateTime();
            /*public static void Main()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Please enter your date of joining in 'mm/dd/yyyy' format in you current organization");
            string s = Convert.ToString(Console.ReadLine());
            DateTime day1 = DateTime.Parse(s, CultureInfo.CreateSpecificCulture("en-US"));
            TimeSpan diff = today - day1;

            Console.WriteLine("It has been {0} days since you joined your current organization", diff.Days);


        }*/
        }
        public static void Main()
        {
            /*DateTime currentdate = DateTime.Today;
            Console.WriteLine(currentdate);*/
            csharphandson_4p1 obj = new csharphandson_4p1();
            obj.time();
        }
    }
}
