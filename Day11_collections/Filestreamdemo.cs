using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day11_collections
{
    class Filestreamdemo
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("C: \\Users\\ARUP PARIDA\\OneDrive\\Documents\\A_Workspace\\Cognizant", 
                FileMode.OpenOrCreate);
            //creating file stream
            f.WriteByte(65);//write byte into stream
            f.Close();//closing stream
            Console.WriteLine("File created");
            Console.ReadLine();
        }
    }
}
