using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_abstraction
{
    public interface Drawable
    {
        void draw();
    }
    public class rectangle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }
    public class circle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }
    public class TestInterface
    {
        public static void Main()
        {
            Drawable d;
            d = new rectangle();
            //new  keyword is used to hide any method of base class in derive class.
            d.draw();
            d = new circle();
            d.draw();
        }
    }

}
