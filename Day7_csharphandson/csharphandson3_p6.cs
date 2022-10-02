using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_csharphandson
{
    class csharphandson3_p6
    {
        public void schedule()
        {
            //string[] day = new string[] { "Morning", "Afternoon", "Evening", "Night" };
            //string[] work = new string[] { "Friends","Girlfriend","Practise","Biking"};

            string input1 = Console.ReadLine();
            if (input1 == "Morning")
            {
                Console.WriteLine("Friends");
            }
            else if (input1 == "Afternoon")
            {
                Console.WriteLine("Girlfriend");
            }
            else if (input1 == "Evening")
            {
                Console.WriteLine("Practise");
            }
            else if (input1 == "Night")
            {
                Console.WriteLine("Biking");
            }
        }
        public static void Main()
        {
            csharphandson3_p6 sobj = new csharphandson3_p6();
            sobj.schedule();
            
        }
    }
}
