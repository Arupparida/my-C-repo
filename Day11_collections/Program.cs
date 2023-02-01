using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //creating a list of integers
            List<int> New_List = new List<int>();
            //<int> Nlist = new <int>
            //adding items to list
            for(int i = 0; i<10;i++)
            {
                New_List.Add(i * 3);                
            }         
            //display list items
            foreach (var items in New_List)
            {
                Console.WriteLine(items);
            }
                
            
        }
    }
}
