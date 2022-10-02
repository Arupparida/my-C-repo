using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_abstraction
{
    public abstract class sample1
    {
        public abstract void display();
    }
    public class Bus : sample1
    {
        public override void display()
        {
            Console.WriteLine("Bus");

        }
    }
    public class twowheeler : sample1
    {
        public  override void display()
        {
            Console.WriteLine("twowheeler");
        }
    }
    class abstractexample
    {
        public static void Main()
        {
            sample1 v;
            v = new Bus();
            v.display();
            v = new twowheeler();
            v.display();
            Console.ReadLine();
        }
    }
}
