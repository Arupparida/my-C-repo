using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day12
{
    //Non-GenericLINQ
    public class StudentData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] Scores { get; set; }

    }
    class NonGenericLINQ
    {
        public static void Main()
        {
            ArrayList arrList = new ArrayList();
            arrList.Add(
                new StudentData
                {
                    FirstName = "Arun",
                    LastName = "Deshpande",
                    Scores = new int[] { 89, 90, 92, 94 }
                });
            arrList.Add(
                new StudentData
                {
                    FirstName =" sunita",
                    LastName = "vaidya ",
                    Scores = new int[] {98,99,94,95}
                }
                );
            arrList.Add(
                new StudentData
                {
                    FirstName = " sujeet",
                    LastName = "karnik ",
                    Scores = new int[] { 97, 99, 94, 95 }
                }
                );
            var query = from StudentData student in arrList
                        where student.Scores[0] > 95
                        select student;
            foreach (StudentData s in query)
                Console.WriteLine(s.FirstName + " " + s.LastName + ":" + s.Scores[0]);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
