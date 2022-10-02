using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_abstraction
{
    class stringsample
    {
        public static void Main()
        {
            /*string f1 = "Microsoft";
            Console.WriteLine(f1.Length);
            string f = "Welcome";
            string f2 = "Welcome";
            int i;
            i = string.Compare( f, f1);
            Console.WriteLine(i); //-1

            f = "Welcome";
            f1 = "Welcome";
            i = string.Compare(f, f1);
            Console.WriteLine(i); //0

            f = "Welcome";
            f1 = "Welcome";
            i = string.Compare(f, f1);
            Console.WriteLine(i); //-1



            string f12 = "Hello";
            string f13 = "World";
            Console.WriteLine(string.Concat(f12, f13));

            string f14 = "Hello";
            string f15 = (string)f14.Clone();

            string f16 = "Welcome";
            Console.WriteLine(f16.EndsWith("me"));

            string f17 = "Welcome";
            Console.WriteLine(f17.Remove(3,4));

            string f18 = "Welcome";
            Console.WriteLine(f18.Replace("e", "a"));

            object o = ".net questions";
            object o1 = o;
            //object o1 = new string(".net questions".ToCharArray());
            Console.WriteLine(o == o1);
            Console.WriteLine(o.Equals(o1));
            Console.ReadLine();*/

            string s11 = "Microsoft";
            Console.WriteLine(s11.Length);
            string s = "welcome";
            string s1 = "Welcome";
            int i;
            i = string.Compare(s, s1);
            Console.WriteLine(i);  //-1

            s = "welcome";
            s1 = "welcome";
            i = string.Compare(s, s1);
            Console.WriteLine(i);  //0

            s = "Welcome";
            s1 = "welcome";
            i = string.Compare(s, s1);
            Console.WriteLine(i);  //+1

            string s12 = "Hello";
            string s13 = "World";
            Console.WriteLine(string.Concat(s13, s12));

            string s14 = "Hello ";
            string s15 = (String)s14.Clone();



            string s16 = "Welcome";
            Console.WriteLine(s16.EndsWith("me"));



            string s17 = "Welcome";
            Console.WriteLine(s17.Remove(3, 4));



            string s18 = "Welcome";
            Console.WriteLine(s18.Replace("e", "a"));



            object o = ".net questions";
            // object o1 = o;
            object o1 = new string(".net questions".ToCharArray());
            Console.WriteLine(o == o1);
            Console.WriteLine(o.Equals(o1));
            Console.ReadLine();



            //System.text namespace contains stringbuilder class which allows you to
            //modify the strings with the help of methods present.


            //System.text namespace contains stringbuider class which allows you to 
            //modify the strings with the help of methods present.



        }
    }
}
