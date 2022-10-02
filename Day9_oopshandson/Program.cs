using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        public static void Main(string[] args)
        {
            Delivery dobj = new Delivery();
            Console.WriteLine("Enter the Over");
            dobj.over = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the ball");
            dobj.ball = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the runs");
            dobj.runs = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the batsman name");
            dobj.batsman = Console.ReadLine();
            Console.WriteLine("Enter the bowler name");
            dobj.bowler = Console.ReadLine();
            Console.WriteLine("Enter the nonStriker name");
            dobj.nonStriker = Console.ReadLine();
        Console.WriteLine("Over : " + dobj.over);
        Console.WriteLine("Ball : " + dobj.ball);
        Console.WriteLine("Runs : " + dobj.runs);
        Console.WriteLine("Batsman : " + dobj.batsman);
        Console.WriteLine("Bowler : " + dobj.bowler);
        Console.WriteLine("NonStriker : " + dobj.nonStriker);

            
           
        }
    }

