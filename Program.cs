using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharpPlayground
{
    class Program
    {
        private string name; //field
        public string Name //properity
        {
            get { return name; }
            set { name = value; }
        }
        public static void Main(string[] args)
        {
            Program mobj = new Program();
            mobj.Name = "MyLion";
            Console.WriteLine(mobj.Name);
        }
    }
}
