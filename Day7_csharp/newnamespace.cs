using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_csharp
{
    class newnamespace
    {
        public static void Main()
        {
            newspace1.space1 obj1 = new newspace1.space1();
            obj1.show();
            newspace2.space1 obj2 = new newspace2.space1();
            obj2.showmustgo_on();
         }
    }
}
namespace newspace1
{
    class space1
    {
        public void show()
        {
            Console.WriteLine("I am testing namespace1");
        }
    }
}
namespace newspace2
{
    class space1
    {
        public void showmustgo_on()
        {
            Console.WriteLine("I am testing namespace2");
        }
    }
}