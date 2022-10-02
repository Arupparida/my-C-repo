using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_oopshandson
{
    //handsonpart1
    class Delivery_hndson8
    {
        public void DisplayDelieveryDetails(string bowler, string batsman)

        {
            
               
                var bsname = bowler.Split(' ');
                //string bfname = bsname[0];
                string blname = bsname[1];
                
                var batsmansurname = batsman.Split(' ');
                string batssurname = batsmansurname[1];
                Console.WriteLine("Bowler:" + blname);
                Console.WriteLine("Batsman:" + batssurname);
            
            
            
        }
        public void DisplayDelieveyDetails(long runs)
        {
            

            if (runs == 6)
            {
                Console.WriteLine("Number of runs scored in the delivery : " +runs);
                Console.WriteLine("It is a boundary");
            }
            else if (runs == 4)
            {
                Console.WriteLine("Number of runs scored in the delivery : " + runs);
                Console.WriteLine("It is a boundary");
            }
            else
            {
                Console.WriteLine(runs);
            }
        }
    }
    class Programm : Delivery_hndson8
    {
        public static void Main()
        {
            Delivery_hndson8 obj = new Delivery_hndson8();
            Console.WriteLine("Menu");
            Console.WriteLine("1.Player details of the delivery");
            Console.WriteLine("2.Run details of the delivery");
            int selection = Convert.ToInt32(Console.ReadLine());
            if (selection == 1)
            {
                Console.WriteLine("Enter the bowler name");
                string bowler = Console.ReadLine();
                Console.WriteLine("Eter the batsman name");
                string batsman = Console.ReadLine();
                obj.DisplayDelieveryDetails(bowler,batsman);
            }
            else if (selection == 2)
            {
                Console.WriteLine("Enter the number of runs");
                long runs = Convert.ToInt32(Console.ReadLine());
                obj.DisplayDelieveyDetails(runs);
            }


        }
    }
}
