using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_abstraction
{
    class LOBexp_handson9_p1
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Please enter the Line of business(LOB) name: ");
                string LOB_name = Console.ReadLine();
                Console.WriteLine("Please enter the account count for the LOB:");
                int count = int.Parse(Console.ReadLine());
                Console.WriteLine("The LOB " + LOB_name + " has " + count + " accounts");

            }
            catch(FormatException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Incorrect value provided for account count.Please check.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
