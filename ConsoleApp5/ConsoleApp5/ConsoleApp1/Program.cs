using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number of students");
            int students = Convert.ToInt32(Console.ReadLine());
            if (students >99)
            {
                Console.WriteLine($" A number of classrooms 100 students is {students/100}");
                students = students % 100;
            }
            if (students >29)
            {
                Console.WriteLine($" A number of classrooms 30 students is {students / 30}");
                students = students % 30;
            }
            if (students > 9)
            {
                Console.WriteLine($" A number of classrooms 10 students is {students / 10}");
                students = students % 10;
            }
            if (students >0)
            {
                Console.WriteLine($" A {students } students is going home");
            }
        }
    }
}
