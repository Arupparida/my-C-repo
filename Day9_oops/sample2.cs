using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_oops
{
    public class sample2 //even class sample2 is correct here
    {
        //static constructor
        static sample2()
        {
            Console.WriteLine("Static constructor called");
        }


        //instance constructor
        //do methods and constructor kind of look same?
        public sample2()
        {
            Console.WriteLine("Instance constructor called");

        }

        //static method
        public static void DisplayInfo()
        {
            Console.WriteLine("DisplayInfo called");

        }
    }
    public class StaticConstrunctor
    {
        public static void Main()
        {
            
            sample2.DisplayInfo();//static constructor called here
            sample2.DisplayInfo();//none of the constructor called
            sample2 iobj = new sample2();
            //iobj.DisplayInfo();
            Console.ReadLine();
        }
    }
}
