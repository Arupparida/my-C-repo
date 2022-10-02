using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_oops
{
    class sample2
    {
        int deptno;
        string dname;
        string loc;

        //this is a constructor (default constructor)
        public sample2()
        {
            deptno = 100;
            dname = "SDE";
            loc = "US";
        }
        //this is a constructor (Parameterised constructor)
        public sample2(int deptno, string dname, string loc)
        {
            this.deptno = deptno;
            this.dname = dname;
            this.loc = loc;
        }
        public void display()
        {
            Console.WriteLine("The department data is" + " " + deptno + " " + dname + " " + loc);

        }
    }
    class DeptData
    {
        public static void Main()
        {
            sample2 cobj = new sample2(100, "sales", "uk"); //this is how parameterised constructors work.
            cobj.display();
            sample2 cobj2 = new sample2();//this is how default constructors work.
            cobj2.display();
            Console.ReadLine();
        }





    }
}
