using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_collections
{
    class Student
    {
        public int rollno { get; set; }
        public string name { get; set; }
        public string branch { get; set; }
    }
    class ArrayListDemo
    {
        public static void Main()
        {
            //object initializer
            Student sobj = new Student { rollno = 10, name = "Ajay", branch = "ECE" };
            Student sobj1 = new Student { rollno = 20, name = "Roshan", branch = "Mech" };
            Student sobj2 = new Student { rollno = 30, name = "Asha", branch = "Civil" };
            Student sobj3 = new Student { rollno = 40, name = "Aman", branch = "cse" };
            ArrayList aobj = new ArrayList();
            aobj.Add(sobj);
            aobj.Add(sobj1);
            aobj.Add(sobj2);
            aobj.Add(sobj3);
            foreach (Student s in aobj)
            {
                Console.WriteLine("The details are " + " " + s.name + " " + s.rollno + " " + s.branch);

            }
            Console.ReadLine();
        }
    }
}
