using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_oopshandson
{
    //Handson8 part2 
    
        public interface IPlayerStatistics
        {
            void DisplayPlayerStatistics();
            

            
        }
     public abstract class Player_hnd8 
    {

        protected string _name;
        protected string _teamName;
        protected int _noOfMatches;

        public void Abstract_hnd8(string _name,string _teamName, int _noOfMatches)
        {
            this._name = _name;
            this._teamName = _teamName;
            this._noOfMatches = _noOfMatches;
        }

    }
    class CricketPlayer : Player_hnd8,IPlayerStatistics
    {
        private int _totalRunsScored;
        private int _noOfWicketsTaken;
        /*public CricketPlayer(int _totalRunsScored, int _noOfWicketsTaken)
        {
            this._totalRunsScored = _totalRunsScored;
            this._noOfWicketsTaken = _noOfWicketsTaken;
        }*/
        public void DisplayPlayerStatistics()
        {
            Console.WriteLine("Enter player Name");
            string _name = Console.ReadLine();
            Console.WriteLine("ENter team Name");
            string _teamName = Console.ReadLine();
            Console.WriteLine("Enter number of matches played");
            int _noOfMatches = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter total runs scored");
            
            Console.WriteLine("ENter total number of wickets taken");
            int _noOfWicketsTaken = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Player Details");
            Console.WriteLine("Player Name : " + _name);
            Console.WriteLine("Team Name : " + _teamName);
            Console.WriteLine("No. of matches : " + _noOfMatches);
            Console.WriteLine("Total runscored : " + _totalRunsScored);
            Console.WriteLine("No of wickets taken : " + _noOfWicketsTaken);
        }
    }
    class HockeyPlayer : Player_hnd8, IPlayerStatistics
    {
        private string _position;
        private string _noOfGoals;
        /*public HockeyPlayer(string _position, string _noOfGoals)
        {
            this._position = _position;
            this._noOfGoals = _noOfGoals;
        }*/
        public void DisplayPlayerStatistics()
        {
            Console.WriteLine("Enter player Name");
            string _name = Console.ReadLine();
            Console.WriteLine("ENter team Name");
            string _teamName = Console.ReadLine();
            Console.WriteLine("Enter number of matches played");
            int _noOfMatches = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter total runs scored");
            string _position = Console.ReadLine();
            Console.WriteLine("ENter total number of wickets taken");
            string _noOfGoals = Console.ReadLine();
            Console.WriteLine("Player Details");
            Console.WriteLine("Player Name : " + _name);
            Console.WriteLine("Team Name : " + _teamName);
            Console.WriteLine("No. of matches : " + _noOfMatches);          
            Console.WriteLine("Position : " + _position);
            Console.WriteLine("No. of goals taken : " + _noOfGoals);
        }
    }

    class program_hansdon
    {
        //private static int _totalRunsScored;
        //private static int _noOfWicketsTaken;

        public static void Main()
        {
            IPlayerStatistics d;
            int _totalRunsScored; //= Convert.ToInt32(Console.ReadLine());
            int _noOfWicketsTaken; //= Convert.ToInt32(Console.ReadLine());
            d = new CricketPlayer(); //_totalRunsScored, _noOfWicketsTaken

            d = new HockeyPlayer();  //_position, _noOfGoals

            Console.WriteLine("Menu");
            Console.WriteLine("1.Cricket Player Details");
            Console.WriteLine("2.Hockey Player Details");
            Console.WriteLine("Enter Choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                d.DisplayPlayerStatistics();
            }
            else if (choice == 2)
            {
                d.DisplayPlayerStatistics();
            }
        }
    }
}
