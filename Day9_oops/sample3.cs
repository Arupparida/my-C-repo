using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_oops
{
    class sample3
    {
        //creating setter and getter for each property
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    class EncapsulationDemo
    {
        static void Main()
        {
            sample3 student = new sample3();
            //setting values to the properties
            student.ID = "101";
            student.Name = "Mohan Ram";
            student.Email = "mohan@exmale.com";
            //getting values
            Console.WriteLine("ID : " + student.ID);
            Console.WriteLine("Name : " + student.Name);
            Console.WriteLine("Email :" + student.Email);
        }
    }
}
