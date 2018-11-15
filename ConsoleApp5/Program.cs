using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");

            int number = Convert.ToInt32(Console.ReadLine());
         
            string primary = "not primary";
            while (primary == "not primary")
            {
                int m = 2;
                while (number > m && number % m != 0)
                {
                    m++;
                }
                if (number == m)
                {
                    Console.WriteLine($"The number {number} is primary number");
                    primary = "primary";
                    Console.WriteLine("exit");
                   
                }
                else
                {
                    Console.WriteLine($"The number {number} is not primary number");
                    Console.WriteLine("Please enter a number");
                    number = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
