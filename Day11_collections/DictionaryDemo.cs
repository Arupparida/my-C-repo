using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_collections
{
    class DictionaryDemo
    {
        //dictionary is generic 
        //hashtable is not generic
        public static void Main()
        {
            Dictionary<int, string> My_dict1 = new Dictionary<int, string>();
            My_dict1.Add(1100, "Welcome");
            My_dict1.Add(1124, "to");
            My_dict1.Add(1125, "Happy Valley");
            foreach(KeyValuePair<int,string> ele1 in My_dict1)
            {
                Console.WriteLine("{0} and {1}", ele1.Key, ele1.Value);

            }
            Console.ReadLine();
        }
    }
}
