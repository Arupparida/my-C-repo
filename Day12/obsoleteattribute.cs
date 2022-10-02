using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    public class obsoleteattribute
    {
        public static void Main()
        {
            //This generates a compile-time warning.
            int MyInt = Add(2, 2);
        }
        [Obsolete("Will be removed in next version")]
        public static int Add(int a,int b)
        {
            return (a + b);
        }
    }
}
