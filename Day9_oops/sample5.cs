using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sample 5 is different from sample 4 as here we are inheriting the constructor in some way i.e Constructors are never inherited but if the derived class has the constructor then it becomes necessary for the base class also to have a constructor.
//Derived class constructors supply values to the base class constructors.
namespace Day9_oops
{
    public class sample5
    {
        int acctno;
        string customername;
        public  sample5(int acctno, string customername)
        {
            this.acctno = acctno;
            this.customername = customername;
            Console.WriteLine("The bank Account details are {0},{1}", acctno, customername);
        }
    }
    public class savingAccount:sample5
    {
        double balance;
        public savingAccount(int accno,string customername,double balance): base(accno, customername)
        //public savingAccount() : base()
        {
            this.balance = balance;
            Console.WriteLine("The saving account details are {0}", balance);
        }
    }
    class accountinfo
    {
        public static void Main()
        {
            savingAccount sobj = new savingAccount(1000, "renu", 560000.23);
            Console.ReadLine();
        }
    }
}
