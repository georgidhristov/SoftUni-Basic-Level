﻿using System;

namespace Problem3SummertimeForProgrammers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= (n - 1) / 2; i++)           
                Console.Write(" ");
            for (int i = 1; i <= n + 1; i++)
                Console.Write("*");
            for (int i = 1; i <= (n - 1) / 2; i++)
                Console.Write(" ");

            Console.WriteLine();

            for (int i = 1; i <= (n + 1) / 2; i++)
            {

                for (int j = 1; j <= (n - 1) / 2; j++) 
                {
                    Console.Write(" ");
                }         

                Console.Write("*");

                for (int j = 1; j <= n - 1; j++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                Console.WriteLine();
            }

            for (int i = 1; i <= (n - 3) / 2; i++)
            {

                for (int j = 1; j <= n / 2 - i; j++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                for (int j = 1; j <= (n - 1) + i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                Console.WriteLine();
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");

                for (int j = 1; j <= (n - 1) * 2; j++)
                {
                    Console.Write(".");
                }

                Console.WriteLine("*");

            }

            for (int i = 1; i <= n; i++)
            {

                Console.Write("*");

                for (int j = 1; j <= (n - 1) * 2; j++)
                {
                    Console.Write("@");
                }

                Console.WriteLine("*");
            }

            for (int i = 1; i <= n * 2; i++)
                Console.Write("*");

            Console.WriteLine();
        }
    }
}
