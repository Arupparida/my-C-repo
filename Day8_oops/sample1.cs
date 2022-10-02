using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_oops
{
    class sample1
    {
        string mobile_brand;
        string color;
        double price;
        int qty;
        

        public void MobileInfo(string mobile_brand,string color,double price, int qty)
        {
            this.mobile_brand = mobile_brand;
            this.color = color;
            this.price = price;
            this.qty = qty;
            Console.WriteLine("The details of Mobile are {0},{1},{2],{3}", mobile_brand, color, price, qty);
        }

    }
    class mobileData
    {
        public static void Main()
        {
            sample1 mobj = new sample1();
            mobj.MobileInfo("VIVO", "RED", 34000.32, 2);
            Console.ReadLine();
        }
    }
}
