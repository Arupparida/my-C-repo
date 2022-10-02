using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_oops
{
    class Laptop
    {
        string os;
        string brand;
        double price;
        string color;
        int size;

        public Laptop()
        {
            os = "windows10";
            brand = "hp";
            price = 50000;
            color = "metalic silver";
            size = 14;
        }
        public Laptop(string os, string brand, double price, string color, int size)
        {
            this.os = os;
            this.brand = brand;
            this.price = price;
            this.color = color;
            this.size = size;
        }

        public void showtime()
        {
            Console.WriteLine("os is : " + os);
            Console.WriteLine("brand is : " + brand);
            Console.WriteLine("price is : " + price);
            Console.WriteLine("color is :" + color);
            Console.WriteLine("size is :" + size);
            Console.WriteLine("\n");
        }

        


    }

    class showon
    {
        public static void Main()
        {
            Laptop lobj = new Laptop();
            lobj.showtime();
            Laptop lobj1 = new Laptop("macintos", "apple", 99000, "metallic Black", 14);
            lobj1.showtime();

        }
    }
}
