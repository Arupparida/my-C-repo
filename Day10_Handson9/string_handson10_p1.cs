using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Handson9
{
    class string_handson10_p1
    {
        public static void Main()
        {
            void substring()
            {
                Console.WriteLine("Enter Player name");
                string name = Console.ReadLine();
                //string sname = name.Substring(name.IndexOf(" "));

                Console.WriteLine("Enter starting index");
                int index = int.Parse(Console.ReadLine());
                string sname = name.Substring(index);
                Console.WriteLine("Short name of " + name + ":" + sname);
            }

            void substring2()
            {
                Console.WriteLine("Enter team name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter starting index of the sequence");
                int first_index = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter ending index of the sequence");
                int last_index = int.Parse(Console.ReadLine());
                Console.WriteLine(name.Substring(first_index, last_index));
            }
            void Ignorecase()
            {
                Console.WriteLine("Enter venue1");
                string venue1 = Console.ReadLine();
                Console.WriteLine("Enter venue2");
                string venue2 = Console.ReadLine();
                if (venue1.Equals(venue2, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Both the venue are same.");
                }
                
            }



            //substring();
            //substring2();
            Ignorecase();
        }
    }
}

