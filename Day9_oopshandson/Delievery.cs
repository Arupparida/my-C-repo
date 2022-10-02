using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_oopshandson
{
    class Delievery
    {
        void DisplayDelieveryDetails(string bowler,string batsman)
        {
            Console.WriteLine("Last Name of bowler:");
            Console.WriteLine("Last Name of batsman:");
        }
        void DisplayDelieveyDetails(long runs)
        {
            if (runs == 6)
            {
                Console.WriteLine("Six" + runs);
            }
            else if (runs == 4)
            {
                Console.WriteLine("Four" + runs) ;
            }
            else
            {
                Console.WriteLine(runs);
            }
        }
    }
}
