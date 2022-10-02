using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_delegate
{
    delegate void DelegateString(string s);
    class singlecastdelegate
    {
        public static void Greet(string Name)
        {
            Console.WriteLine("Hello...." + Name);
        }
        public static void Main()
        {
            //instantiate delegate
            DelegateString delegateobj1 = new DelegateString(Greet);
            //invoke delegate
            delegateobj1("goodmorning");
            Console.WriteLine("----------------------");
            Console.ReadLine();
        }
    }
}
