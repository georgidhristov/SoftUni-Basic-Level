using System;

namespace Problem1ExchangeIfGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a <= b)
            {
                Console.Write(a + " ");
                Console.WriteLine(b);
            }
            else
            {
                Console.Write(b + " ");
                Console.WriteLine(a);
            }
        }
    }
}
