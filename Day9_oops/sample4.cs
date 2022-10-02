using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_oops
{
    class sample4
    {
        string name;
        string address;
        public void getData(string name,string address)
        {
            this.name = name;
            this.address = address;
            Console.WriteLine("The details are {0},{1}", name, address);
        }
    }
    class compman:sample4
    {
        int empno;
        double salary;
        string desig;
        public void profile(int empno,double salary,string desig)
        {
            this.empno = empno;
            this.salary = salary;
            this.desig = desig;
            Console.WriteLine("The profile details are {0},{1},{2}",empno,salary,desig);
        }
    }
    public class InheritDemo
    {
        public static void Main()
        {
            compman eobj = new compman();
            //sample4 eobj1 = new sample4();            
            //eobj1.getData("ram", "cochin");
            eobj.getData("ram", "cochin");
            eobj.profile(12, 4000000, "developer");
            Console.ReadLine();


        }
    }
}
