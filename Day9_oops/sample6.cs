using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_oops
{
    public class sample6
    {
        public string MobileName { get; set; }
        public string DisplayType { get; set; }
        public sample6()
        {

        }
        public string GetMobileDetails()
        {
            return this.DisplayType+" " + "is used by"+" "+ this.MobileName;
        }
    }
    public class DisplayScreen
    {
        public static string ScreenType()
        {
            return "This led screen display";
        }
    }
    class Program1
    {
        public static void Main()
        {
            sample6 objMobile = new sample6();
            objMobile.MobileName = "MI pico 4";
            objMobile.DisplayType = DisplayScreen.ScreenType();
            Console.WriteLine(objMobile.GetMobileDetails());
        }
    }
}
