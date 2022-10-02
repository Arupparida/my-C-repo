using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_abstraction
{
    public class InvalidAgeException : ApplicationException
    {
        public InvalidAgeException(string message) : base(message)
        {

        }
    }
    class userdefinedexceptiondemo
    {
        public static void Main()
        {
            int age;
            try
            {
                Console.WriteLine("Enter age of person");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
                {
                    throw new InvalidAgeException("Sorry,Age must be greater than 18");
                }
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e);

            }
            Console.WriteLine("Rest of the code");
            Console.WriteLine();


        }
    }
}
