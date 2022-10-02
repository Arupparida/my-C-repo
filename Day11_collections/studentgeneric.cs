using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_collections
{
    public class studentgeneric

    {
        public static void Main() {
            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add(null); //null is allowed
            Console.WriteLine("No of elements: " + cities.Count);

            var students = new List<Student>()
        {
            new Student(){ rollno = 10, name = "Ajay", branch = "ECE" },
            new Student(){ rollno = 10, name = "Ajay", branch = "ECE" },
        };
            Console.WriteLine("No of elements: " + students.Count);
            Console.ReadLine();

        }
    }
    /*class Student
    {
        public int rollno { get; set; }
        public string name { get; set; }
        public string branch { get; set; }
    }*/

}
