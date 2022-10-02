using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day11_collections
{
    class StreamWriterDemo
    {
        public static void Main()
        {
            string[] names = new string[] { "Amit", "vijay" };
            using(StreamWriter sw = new StreamWriter("C: \\Users\\ARUP PARIDA\\OneDrive\\Documents\\A_Workspace\\Cognizant"))
            {
                foreach(string s in names)
                {
                    sw.WriteLine(s);                }
            }
            //Read and show each line from the file.
            string line = "";
            using(StreamReader sr = new StreamReader("C: \\Users\\ARUP PARIDA\\OneDrive\\Documents\\A_Workspace\\Cognizant"))
            {
                while((line=sr.ReadLine())!= null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadLine();
        }
    }
}
