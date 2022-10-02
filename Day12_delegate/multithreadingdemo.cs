using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day12_delegate
{
    class multithreadingdemo
    {
        void Runthread_Task()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\tMsg #{0} from the secondary thread", i);
            }
        }
        void RunThread()
        {
            Thread t = new Thread(new ThreadStart(Runthread_Task));
            //run the new thread
            t.Start();
            //print some mesaage to the console window
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Msg #{0} from Main Thread", i);
            }
            Console.WriteLine("End of Main Thread Program");
        }
        public static void Main()
        {
            multithreadingdemo obj = new multithreadingdemo();
            obj.RunThread();
            Console.ReadLine();
        }
    }
}
