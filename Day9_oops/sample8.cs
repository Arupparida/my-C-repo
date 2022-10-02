using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_oops
{
    class sample8
    {
        public virtual void Greetings()
        {
            Console.WriteLine("baseclass saying Hello!");
        }
    }
    class subclass : sample8 //aka sample 8 is base class hence subclass inherits baseclass
    {
        public override void Greetings()
        {
            base.Greetings();
            Console.WriteLine("subclass saying Hello!");
        }
    }
    class MethodOverrideDemo
    {
        public static void Main()
        {
            sample8 obj1 = new subclass();
            obj1.Greetings();
            Console.ReadLine();

        }
    }
        

}

    