using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_csharp
{
    class sample12
    {
        public double calculateRadius()
        {
            const double Pi = 3.14;
            double radius, area;
            radius = 10.0;
            area = Pi * radius * radius;
            Console.WriteLine("Area of circle= " + area.ToString());
            return area;
        }
        
    }
    class MethodDemo
    {
        public static void Main()
        {
            sample12 obj = new sample12();
            Console.WriteLine("Method call to calculate radius of circle");
            double result = obj.calculateRadius();
            Console.ReadLine();
        }

    }
   
}
