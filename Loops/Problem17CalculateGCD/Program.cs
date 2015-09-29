﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17CalculateGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());


            while (a != 0 && b != 0 && a > 0 && b > 0)
            {
                if (a > b)
                {
                    a = a % b;
                }

                else
                {
                    b = b % a;
                }
            }

            if (a == 0)
            {
                Console.WriteLine(b);
            }
            else if (a > 0 && b < 0)
            {
                Console.WriteLine(a);
            }
            else if (b > 0 && a < 0)
            {
                Console.WriteLine(b);               
            }
            else
            {
                Console.WriteLine(a);
            }             
        }
    }
}
