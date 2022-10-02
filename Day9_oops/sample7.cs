using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_oops
{
    class sample7
    {
        public void compute()
        {
            Console.WriteLine("Tutorial of method overloading");

        }
        public string compute(string message)
        {
            Console.WriteLine("The message is {0}", message);
            return message;
        }
        public int compute(int number1,int number2)
        {
            int result;
            result = number1 + number2;
            Console.WriteLine("The sum is {0}", result);
            return result;
        }
    }

    class MethodOverloadDemo
    {
        public static void Main()
        {
            sample7 cobj = new sample7();
            cobj.compute();
            cobj.compute("Hello World");
            cobj.compute(100, 200);
            Console.ReadLine();
        }
    }
}
