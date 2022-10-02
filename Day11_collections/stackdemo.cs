using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_collections
{
    class stackdemo
    {
        static void Main()
        {
            System.Collections.Stack stackobj = new System.Collections.Stack();
            stackobj.Push("Hello");
            stackobj.Push("stack");
            stackobj.Push("class");
            stackobj.Push("example");
            Console.WriteLine("Count = " + stackobj.Count.ToString());
            Console.WriteLine("\n-------------------\n");
            foreach(object obj in stackobj)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine("\n----------Top Element- peek method -------\n");
            Console.WriteLine(stackobj.Peek());
            Console.WriteLine("\n-----------Top Element - pop method -------\n");
            Console.WriteLine(stackobj.Pop());
            Console.WriteLine("\n----------count-----------\n");
            Console.WriteLine("Count = " + stackobj.Count.ToString());
            foreach(object obj in stackobj)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.ReadLine();

        }
    }
}
