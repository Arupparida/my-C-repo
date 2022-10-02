using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_collections
{
    class queuedemo
    {
        public static void Main()
        {
           Queue queueobj = new Queue();
            queueobj.Enqueue("Hello");
            queueobj.Enqueue("Queue");
            queueobj.Enqueue("Class");
            queueobj.Enqueue("example");
            Console.WriteLine("count = " + queueobj.Count.ToString());
            foreach (object obj in queueobj)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine("\n-------------------\n");
            foreach (object obj in queueobj)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine("\n----------Top Element- peek method -------\n");
            Console.WriteLine(queueobj.Dequeue());
            Console.WriteLine("\n----------count-----------\n");
            Console.WriteLine("Count = " + queueobj.Count.ToString());
            foreach (object obj in queueobj)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.ReadLine();
        }

    }
}
