﻿using System;

namespace Problem1NumbersFrom1toN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
        }
    }
}
