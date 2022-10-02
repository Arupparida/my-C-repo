using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_oops
{


    /*class emp : empno, ename, designation, salary are the data 
     * members​ 
     * getEmpData() and ShowData()    
    getEmpData() take all user inputs thus no parameters needed
    ShowData() will print the data
    Add the additional method public double CalculateSalary() method in Emp class.
    Basis on desig  whether trainee, developer or TL the gross salary is to be calculated and displayed.
    Take the details of salary from javascript assignment
     
     
     */

    class emp
    {
        int empno;
        string ename;
        string designation;
        double salary;
        double TA;
        double hra;
        double da;
        double pf;
        double Gross_salary;
        
        public void getEmpData()
        {
            Console.WriteLine("enter Employee number");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name");
            ename = Console.ReadLine();
            Console.WriteLine("Enter employee designation");
            designation = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            salary = Convert.ToDouble(Console.ReadLine());



        }
        public void showData()
        {
            Console.WriteLine("Employee id : " + empno);
            Console.WriteLine("Employee Name : " + ename);
            Console.WriteLine("Employee designation : " + designation);
            Console.WriteLine("Employee Salary : " + salary);
        }
        public double CalculateSalary()
        {

            if (designation == "developer")
            {
                hra = 0.1 * salary;
                da = 0.2 * salary;                
                TA = 1000.00;
            }
            else if (designation == "trainee")
            {
                hra = 0.05 * salary;
                da = 0.1 * salary;
                TA = 500.00;
            }
            else if (designation == "projectmanager")
            {
                hra = 0.25 * salary;
                da = 0.3 * salary;
                TA = 2000.00;
            }
            else
            {
                Console.WriteLine("not a valid input");
            }
            double Gross_salary = salary + hra + da + TA;
            Console.WriteLine("Gross salary of " + designation + " is: " + Gross_salary.ToString());
            return Gross_salary;
        }
        public static void Main()
        {
            emp eobj = new emp();
            eobj.getEmpData();
            eobj.showData();
            eobj.CalculateSalary();

        }
    }

}
