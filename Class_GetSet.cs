using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharpPlayground
{
    class Class_GetSet
    {
        private string name; //field  //Concept of encpasulation

        /* 
         meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. 
        To achieve this, you must:
            1. declare fields/variables as private
            2.provide public get and set methods, through properties, to access and update the value of a private field
            2.provide public get and set methods, through properties, to access and update the value of a private field
         
         */

        public string Name //Try keeping the same name 
        {
            get { return name; }
            set { name = value; }

        }
        public static void Main()
        {

            Class_GetSet nobj = new Class_GetSet();
            nobj.Name = "newvalueset";
            Console.WriteLine(nobj.Name);

        }

    }

    /*class printmain
    {
        public static void Main()
        {
            
                Class_GetSet nobj = new Class_GetSet();
                nobj.Name = "newvalueset";
                Console.WriteLine(nobj.Name);
           
        }
    }*/
}
