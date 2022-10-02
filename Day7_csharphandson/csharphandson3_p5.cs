using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_csharphandson
{
    class csharphandson3_p5
    {

        public void check_team()
        {
            int j  = Convert.ToInt32(Console.ReadLine());
            if (j < 0)
            {
                Console.WriteLine("Invalid Input");
                
            }
            string[] teams = new string[j];

           

            
            
            for (int i = 0; i < teams.Length; i++)
            {
                teams[i] = Console.ReadLine();               
            }
            string checkcity = Console.ReadLine();
            var check = Array.Exists(teams, x=> x == checkcity);
            var index = Array.FindIndex(teams, x => x == checkcity);
            if (check == true)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No");

            }
            

        }
        public static void Main()
        {
            csharphandson3_p5 obj = new csharphandson3_p5();
            obj.check_team();
            //Console.ReadLine();
        }
    }
}
