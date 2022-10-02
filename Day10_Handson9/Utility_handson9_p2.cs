using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Handson9
{
    static class Utility_handson9_p2 
    {
        static void GetLOBAcctCount(string LOBname, int acctcount)
        {
            Console.WriteLine("Please enter the Line of Business(LOB) name:");
            LOBname = Console.ReadLine();
            Console.WriteLine("Please enter the account count for the LOB:");
            acctcount = int.Parse(Console.ReadLine());
            //return string.Concat(LOBname , acctcount);
            Console.WriteLine("The LOB " + LOBname + " has " + acctcount + " accounts"); 
        }
    }
    class programhandson9_p2 
    {
        public static void Main(string[] args)
        {
            try
            {
                //throw new void GetLOBAcctCount(LOBname, acctcount);
                
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Exception caught at Main method: Incorrect value provided for Account count.Please check.");
            }
            finally
            {
                Console.ReadLine();
            }
        } 
    }
}
