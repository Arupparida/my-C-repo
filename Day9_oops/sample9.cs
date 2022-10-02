using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//important topic : runtime polymorphism
namespace Day9_oops
{
    class sample9
    {
        public virtual void Draw()
        {
        }
    }
    class Rectangle : sample9
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle Drawn");
        }
    }
    class Circle : sample9
    {
        public override void Draw()
        {
            Console.WriteLine("Circle Drawn");
        }
    }
    class RuntimepolyDemo
    {
        static void Main()
        {
            sample9[] s = new sample9[2];
            s[0] = new Circle();
            s[1] = new Rectangle();
            Console.WriteLine("\n\nRuntime polymorphism test\n\n");
            for (int i = 0; i < 2; i++)
            {
                s[i].Draw();

            }
            Console.ReadKey();


        }
    }
}
