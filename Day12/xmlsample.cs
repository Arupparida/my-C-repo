using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day12
{
    class xmlsample
    {    


        
        
            public static void Main()
            {
                //XmlDocument class - Represents an XML document. can move in any direction



                XmlDocument doc = new XmlDocument();
                doc.Load(@"D:\cognizant 2022\Day_OOPS\books.xml"); //change the location to ur system location



                Console.WriteLine("---------Title------------");
                XmlNodeList nodeList = doc.GetElementsByTagName("title");
                foreach (XmlNode node in nodeList)
                {
                    Console.WriteLine(node.InnerText);
                }
                Console.WriteLine("------------------------------------");
                XmlNodeList nodeList1 = doc.GetElementsByTagName("author");
                foreach (XmlNode node in nodeList1)
                {
                    Console.WriteLine(node.InnerText);
                }
                Console.WriteLine("------------------------------------");
            }
        }
    }


