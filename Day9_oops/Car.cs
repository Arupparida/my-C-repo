using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_oops
{
    class Car
    {
        string modelname;
        //old way of writing property
        public string Model_Name
        {
            get
            {
                return modelname;
            }
            set
            {
                modelname = value;
            }

        }
        class CarDemo
        {
            public static void Main()
            {
                Car cobj = new Car();
                cobj.Model_Name = "Audi";
                Console.WriteLine(cobj.Model_Name);
                Console.ReadLine();



            }
        }
}
