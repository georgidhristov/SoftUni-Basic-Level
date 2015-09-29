using System;

namespace Problem7Sort3NumbersWithNestedLfs
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.Write(" " + a);
                if (b >= c)
                {
                    Console.Write(" " + b);
                    Console.Write(" " + c);
                }
                else if (c >= b)
                {
                    Console.Write(" " + c);
                    Console.Write(" " + b);
                }
                Console.WriteLine();
            }
            else if (b >= a && b >= c)
            {
                Console.Write(" " + b);
                if (a >= c)
                {
                    Console.Write(" " + a);
                    Console.Write(" " + c);
                }
                else if (c >= a)
                {
                    Console.Write(" " + c);
                    Console.Write(" " + a);
                }
                Console.WriteLine();
            }
            else if (c >= a && c >= b)
            {
                Console.Write(" " + c);
                if (a >= b)
                {
                    Console.Write(" " + a);
                    Console.Write(" " + b);
                }
                else if (b >= a)
                {
                    Console.Write(" " + b);
                    Console.Write(" " + a);
                }
                Console.WriteLine();
            }
        }
    }
}
