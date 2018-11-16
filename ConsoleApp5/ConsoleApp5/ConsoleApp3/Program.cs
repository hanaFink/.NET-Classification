using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int triangle = Convert.ToInt32(Console.ReadLine());
            //start *
            int counter1= triangle / 2 +1;
            // end *
            int counter2 = triangle / 2 +1 ;

            // colomn
            for (int i = 0; i <= triangle ; i++)
            {
                //row
                for (int j = 0; j <= triangle; j++)
                {
                      if (j > counter1 && j< counter2)
                        Console.Write("*");
                      else
                        Console.Write(" ");

                }
                counter1--;
                counter2++;
                // stoped after full row of stars
                if (counter1< 0 && counter2 > triangle)
                    break;

                Console.WriteLine();
            }

            
        }
    }
}
