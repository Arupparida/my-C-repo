﻿using System;
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
            
            
            
            //creating arraylist 
            //comment section not in use for Csharp collection section '
            ArrayList al =  new ArrayList();
            string sent =  "This is today's push";
            int x =  7;
            DateTime d = DateTime.Parse("10-Oct-2022");
            al.add(sent);
            al.add(x);
            al.add(d);
            
            foreach(object obj in al){
                Response.Write (obj);
                Resonse.Write("<br>");
            }
                
            
        }
    }
}
