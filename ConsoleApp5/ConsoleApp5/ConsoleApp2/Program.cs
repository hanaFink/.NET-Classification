﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int triangle = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= triangle; i++)
            { 
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
            
                Console.WriteLine();
             
            }
            for (int i = triangle; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();

            }
        }
    }
}
