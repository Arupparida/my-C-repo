using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_oops
{
    public static class sample1

    {
        public static float PI = 3.14f;
        public static int calc(int n)
        {
            return n * n;
        }
    }

    class Programstatic { 
        public static void Main()
        {
            Console.WriteLine("PI: " + sample1.PI);
            Console.WriteLine("Square: " + sample1.calc(3));
        }
    }
}
